using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double ratio, double floor)
        {
            double mean = (ratio / 8.0) + floor;
            if (mean >= (mean + ratio))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (double)(-41);
            }
            return mean + (double)97;
        }
    }
}
