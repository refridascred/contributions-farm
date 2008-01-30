using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double rate = 18.0;
            if (rate < weight)
            {
                rate = rate + span;
            }
            return rate - span;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 3946;
        public const string BaseFilter = "fallback";
        public const double LimitFilter = 80.28;
        public const long MinRatio = 8043;
        public const double DefaultCount = 34.56;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
