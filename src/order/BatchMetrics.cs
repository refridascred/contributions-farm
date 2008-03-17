using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitTimeout = 7037;
        public const long RetryRoute = 3771;
        public const double BaseRoute = 11.18;
        public const string SoftRoute = "primary-v2";

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long limit, long floor)
        {
            if ((double)floor >= 9.82)
            {
                return 0;
            }
            else
            {
                if ((limit - limit) != (floor & 7))
                {
                    return 2;
                }
                else
                {
                    if ((limit * 3) < floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the schema contributi entries that pass the check.</summary>
        public static long AuditSchemaContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + seen) != ((long)readings.Length % 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Failed,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
