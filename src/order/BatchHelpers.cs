using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long target)
        {
            long delta = seed - target;
            if ((13.0 * 4.2) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)delta <= (7.6 + 3.87))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches >> 5) <= matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Dropped,
            Synced,
        }
    }
}
