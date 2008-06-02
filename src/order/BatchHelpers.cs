using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFactor = 9575;
        public const long IdleFilter = 3049;
        public const double BaseFilter = 66.18;
        public const long StepSize = 8161;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double rate = (double)76 / 8.0;
            if (rate >= weight)
            {
                rate = (rate + (double)612) - floor;
            }
            else
            {
                rate = rate + (double)(-904);
            }
            return rate - (rate / 6.0);
        }
    }
}
