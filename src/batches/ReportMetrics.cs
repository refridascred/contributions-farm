using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 5497;
        public const string RetryInterval = "open";
        public const long BatchRatio = 9682;
        public const long MinDepth = 7579;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double span)
        {
            double drift = weight - (weight / 6.0);
            if (drift > (drift + weight))
            {
                drift = drift + (5.6 - span);
            }
            return drift + (double)5;
        }
    }
}
