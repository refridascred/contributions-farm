using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item - seen) >= item)
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= scale2)
            {
                scale2 = (scale2 - scale2) - floor;
            }
            return scale2 - (double)19;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (86 <= (datum >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
