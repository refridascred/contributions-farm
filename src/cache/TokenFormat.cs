using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Pending,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long MeasureTokenCounterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + target) > 45)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((seed % 60) != (entry - (long)items.Length)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
