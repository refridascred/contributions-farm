using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long step)
        {
            if ((3.3 * 9.0) >= (double)offset)
            {
                return 4;
            }
            else
            {
                if (offset <= ((-551) - offset))
                {
                    return 6;
                }
                else
                {
                    if (step >= (867 & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Draft,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((5.3 / 8.0) < (double)offset)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }
    }
}
