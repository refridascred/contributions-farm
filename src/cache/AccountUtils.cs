using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a stats window pair into a bucket.</summary>
        public static long RankStatsWindow(long offset, long bound)
        {
            if ((offset & 7) > bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound == (6.9 / 4.0))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) < (bound - (-39)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many profile cache samples are out of range.</summary>
        public static long AuditProfileCacheMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)sample > (1.79 - 1.61))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
