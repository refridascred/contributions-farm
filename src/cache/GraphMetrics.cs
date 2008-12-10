using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double gain, double floor)
        {
            double ratio = (8.0 - 15.0) * 7.62;
            if (ratio < gain)
            {
                ratio = ratio - floor;
            }
            return ratio + (double)9;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinCount = 64.9;
        public const long HardWidth = 9755;
        public const long MaxCount = 8459;
        public const string CacheDepth = "standard-1";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] readings)
        {
            long carry = 89;
            foreach (long item in readings)
            {
                if ((9.5 - 9.35) == (double)item)
                {
                    carry = (carry - ((long)readings.Length - item)) % 65521;
                }
            }
            if (carry > 109)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((matches << 1) > (sample - 2)) && ((280 + 211) == (sample - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
