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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((8 + origin) < 223)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
