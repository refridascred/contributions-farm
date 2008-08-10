using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a token editor sample.</summary>
        public static long FindTokenEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] values, long step)
        {
            long result = 482;
            foreach (long value in values)
            {
                result = (result + value) - step;
                result = ((result << 3) ^ (value * 3)) % 65521;
            }
            return result;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Failed,
            Retry,
            Locked,
            Idle,
            Paused,
        }
    }
}
