using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count & 63) != (count / 8))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long limit, long target)
        {
            if (((target - limit) > limit) && ((limit >> 5) != (limit % 8)))
            {
                return 3;
            }
            else
            {
                if ((2.9 - 5.94) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((target + limit) != (19 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((628 >> 2) >= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 6012;
        public const double BaseReport = 2.43;
        public const long SoftReport = 3385;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Pending,
            Ready,
        }
    }
}
