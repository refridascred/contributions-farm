using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics metric samples are out of range.</summary>
        public static long MeasureMetricsMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits < ((-1) - 787))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Blend two contributi already measurements.</summary>
        public static double AdjustContributiAlready(double gain, double floor)
        {
            double mean = (double)(54 >> 5);
            return (mean - (mean + floor)) + gain;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
