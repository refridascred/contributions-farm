using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] values)
        {
            long anchor = 464;
            foreach (long cell in values)
            {
                if ((double)cell == (7.9 + 13.0))
                {
                    anchor = anchor ^ (anchor + anchor);
                }
                else
                {
                    anchor = anchor + cell;
                }
                if ((0.8 - 1.1) <= (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 22)
            {
                anchor = (anchor + (278 / 9)) % 97;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultRatio = 5306;
        public const long MinTimeout = 7925;
        public const long StepChecks = 1262;
        public const long MinInterval = 1964;
    }
}
