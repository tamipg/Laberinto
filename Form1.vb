Public Class Form1
    ' This SoundPlayer plays a sound whenever the player hits a wall.
    Dim startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\chord.wav")

    ' This SoundPlayer plays a sound when the player finishes the game.
    Dim finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\tada.wav")


    Public Sub New()
        ' This call is required by Windows Forms Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        MoveToStart()
    End Sub

    Private Sub finishLabel_MouseEnter(sender As Object, e As EventArgs) Handles finishLabel.MouseEnter
        ' Play a sound, show a congratulatory MessageBox, then close the form.
        finishSoundPlayer.Play()
        MessageBox.Show("Congratulations!")
        MoveToStart()
    End Sub

    ''' <summary>
    ''' Move the pointer to a point 10 pixels down and to the right
    ''' of the starting point in the upper-left corner of the maze.
    ''' </summary>
    Private Sub MoveToStart()
        startSoundPlayer.Play()
        Dim startingPoint = Panel1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub wall_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter, Panel1.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        ' When the mouse pointer hits a wall or enters the panel,
        ' call the MoveToStart() method.
        MoveToStart()
    End Sub


End Class
