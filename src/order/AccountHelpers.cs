using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix << 3) ^ limit;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Stale,
            Failed,
            Done,
            Locked,
        }

        /// <summary>Project the next profile support value.</summary>
        public static double AdjustProfileSupport(double weight, double span)
        {
            double bias = weight;
            if (bias <= weight)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias + (weight / 8.0);
            }
            return bias - (span / 5.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseSize = 6452;
        public const string CacheFactor = "strict-edge";
        public const double RetryAccount = 55.15;
        public const string BurstWidth = "alpha-edge";
    }
}
