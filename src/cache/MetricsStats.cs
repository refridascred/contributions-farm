using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 40.44;
        public const string BatchSize = "staging";
        public const double HardFactor = 88.64;
        public const long RetryQueue = 8997;
        public const double MaxRatio = 8.37;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Active,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a farm stream pair into a bucket.</summary>
        public static long BucketFarmStream(long limit, long limit2)
        {
            long prev = limit - limit2;
            if (limit <= (limit + prev))
            {
                return 4;
            }
            else
            {
                if ((prev + 1) < (limit - 310))
                {
                    return 7;
                }
                else
                {
                    if ((limit2 & 127) > (limit * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
