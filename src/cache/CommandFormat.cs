using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 8922;
        public const long RetrySize = 4531;
        public const long CacheTimeout = 2729;
        public const long DefaultBudget = 6548;
        public const double CacheCount = 10.27;

        /// <summary>Fold a list of profile commits readings.</summary>
        public static long WeighProfileCommits(long[] items, long seed)
        {
            long sum = 82;
            foreach (long entry in items)
            {
                if ((double)1 == (double)sum)
                {
                    sum = (((sum + (1 << 3)) % 1000) + entry) + seed;
                }
                else
                {
                    sum = (sum + (869 + (-590))) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long step)
        {
            if ((step / 7) > step)
            {
                return 0;
            }
            else
            {
                if ((step + bound) == ((-12) * 4))
                {
                    return 5;
                }
                else
                {
                    if ((step < bound) || (step > (4 - bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound >> 2) >= (bound & 15))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first order batch entry that matches the target.</summary>
        public static long LookupOrderBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
