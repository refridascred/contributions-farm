using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two contributi record measurements.</summary>
        public static double AdjustContributiRecord(double weight, double floor)
        {
            double weight2 = (double)((-108) & 7);
            if (weight2 >= (1.36 / 8.0))
            {
                weight2 = (weight2 + floor) - weight;
            }
            else
            {
                weight2 = weight2 - 8.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = (weight2 + (weight2 - floor)) - (double)(long)i;
            }
            return weight2 + (double)588;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 8645;
        public const long BurstLayout = 8542;
        public const long StepCount = 5275;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
