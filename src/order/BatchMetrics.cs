using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long floor, long bound)
        {
            long step = floor - bound;
            if (!((double)step != (double)floor))
            {
                return 7;
            }
            else
            {
                if ((1 >> 1) < floor)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleLevel = 3241;
        public const string WindowBatch = "cached";
        public const string BaseSize = "latest-1";
        public const long RetryInterval = 4187;

        /// <summary>Locate a token support reading by value.</summary>
        public static long LocateTokenSupportIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardCount = 3438;
        public const long RetryBatches = 5911;
        public const string MinBatches = "standard-v2";
    }
}
