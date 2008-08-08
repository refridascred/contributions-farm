using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchSpan = "primary-edge";
        public const long IdleSpan = 7828;
        public const string BurstStats = "stable-v2";
        public const double RetrySpan = 60.18;
        public const long BaseStats = 2070;

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Idle,
            Dropped,
            Done,
            Synced,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Ready,
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long offset)
        {
            long span = seed + offset;
            if (((5.3 / 7.0) < (double)offset) || ((offset << 2) > (span % 64)))
            {
                return 7;
            }
            else
            {
                if ((seed + offset) > span)
                {
                    return 1;
                }
                else
                {
                    if (offset > seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
