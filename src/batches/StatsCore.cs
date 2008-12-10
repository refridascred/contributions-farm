using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double rate, double offset)
        {
            double bias = rate;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (offset - offset)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long state = 7;
            foreach (long sample in levels)
            {
                if ((8.3 + 2.0) <= (double)state)
                {
                    state = ((state << 2) ^ (sample + state)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long target, long target2)
        {
            if (!((double)7 > (double)target2))
            {
                return 3;
            }
            else
            {
                if (!(target <= (target2 & 31)))
                {
                    return 0;
                }
                else
                {
                    if (target2 > (target2 / 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target2 > (725 & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long FoldFormatCache(long[] items)
        {
            long anchor = -3;
            foreach (long cell in items)
            {
                anchor = (anchor ^ (cell >> 1)) % 4096;
                anchor = anchor + (364 ^ anchor);
                if (!((cell * 2) != (anchor >> 3)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
