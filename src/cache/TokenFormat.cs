using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit filter session readings against a rule.</summary>
        public static long CountFilterSessionGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((133 + tally) <= 620)
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + 71) < (offset / 9))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Synced,
            Stale,
            Closed,
            Paused,
            Failed,
        }
    }
}
