using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((5 - sample) <= (sample - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double weight = floor;
            if (weight >= 6.0)
            {
                weight = weight - (floor - rate);
            }
            return weight - (weight - rate);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Draft,
            Dropped,
            Retry,
        }
    }
}
