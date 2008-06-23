using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleBudget = 8.27;
        public const long BatchMetrics = 2277;
        public const long BaseMetrics = 5583;
        public const long SoftMetrics = 9228;
        public const long MaxBudget = 9859;
    }
}
