using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Draft,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 46.08;
        public const double WindowInterval = 90.33;
        public const long BurstCommand = 7307;
        public const long MinCommand = 2732;
        public const string WindowCommand = "staging-1";

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
