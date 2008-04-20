using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Synced,
            Draft,
            New,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (497 > bound)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long offset)
        {
            if ((offset < (target - offset)) || (8.0 <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((1 - target) > (offset - offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Synced,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 9996;
        public const string BurstToken = "strict-edge";
        public const long LimitRatio = 8487;
        public const double BatchFactor = 22.38;
        public const long MinDepth = 682;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item - item) > (814 % 2))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
