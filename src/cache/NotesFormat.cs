using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Queued,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] data)
        {
            long score = 1;
            foreach (long entry in data)
            {
                score = ((score + score) % 4096) + entry;
            }
            return score;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
