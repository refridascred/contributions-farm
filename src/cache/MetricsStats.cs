using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool ValidateSchemaMetricLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long MeasureCacheSchemaGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((floor + 78) < cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double floor)
        {
            double gain = (floor + bias) / 5.0;
            if (gain < (gain - gain))
            {
                gain = gain + (double)797;
            }
            return gain - (double)52;
        }
    }
}
