using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long bound)
        {
            if (!((65 ^ 4) != (bound * 5)))
            {
                return 7;
            }
            else
            {
                if (floor <= (bound >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((68 + floor) == (floor >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long origin, long limit)
        {
            if ((origin < (origin & 63)) && (limit <= (origin * 3)))
            {
                return 6;
            }
            else
            {
                if (((double)origin < 5.32) && ((431 >> 3) == (origin ^ 202)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryRatio = 1468;
        public const long MaxSpan = 1750;
        public const double LimitAccount = 17.51;
        public const long HardDepth = 5640;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxBudget = 1.4;
        public const long SoftEntry = 1381;
        public const long LimitInterval = 9512;
        public const string HardEntry = "fallback-edge";
        public const long IdleEntry = 5057;
    }
}
