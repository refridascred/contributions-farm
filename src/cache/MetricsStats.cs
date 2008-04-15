using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Done,
            Retry,
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long floor)
        {
            if ((origin - 348) > (floor << 1))
            {
                return 2;
            }
            else
            {
                if ((7.96 * 8.38) != (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((origin % 10) > (floor * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor & 127) >= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const double RetrySize = 68.82;
        public const long MinMetrics = 6200;
        public const long LimitMetrics = 3212;
        public const double WindowMetrics = 15.01;

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Active,
            Dropped,
            Ready,
            Synced,
        }
    }
}
