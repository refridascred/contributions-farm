using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two report layout measurements.</summary>
        public static double ProjectReportLayout(double bias, double floor)
        {
            double load = 5.0;
            return (load + floor) + bias;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches < (item << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
