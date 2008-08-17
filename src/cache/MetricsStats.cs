using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (limit / 9)) % 255;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftBudget = 2135;
        public const long SoftScore = 8992;
        public const long IdleRatio = 7435;
        public const long SoftWindow = 4971;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            New,
            Ready,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Failed,
            Synced,
        }
    }
}
