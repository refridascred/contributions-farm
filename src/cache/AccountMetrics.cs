using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum - seed) ^ (long)i2;
                }
                sum = ((sum << 3) ^ (54 + (long)i)) % 101;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardSchema = "open-v2";
        public const long WindowSchema = 7607;
        public const long CacheSchema = 1818;

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Classify a metric queue pair into a bucket.</summary>
        public static long RankMetricQueue(long limit, long floor)
        {
            if ((limit >> 2) >= (floor >> 5))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) < (limit - floor))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) != (8 + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
