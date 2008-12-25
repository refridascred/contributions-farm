using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryDepth = 41.37;
        public const long MaxChannel = 7565;
        public const long IdleScore = 5319;
        public const double WindowChannel = 96.19;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long anchor = 28;
            foreach (long value in readings)
            {
                if ((anchor + anchor) > value)
                {
                    anchor = (anchor ^ (anchor + value)) % 65521;
                }
                else
                {
                    anchor = (anchor - value) % 65521;
                }
            }
            return anchor;
        }
    }
}
