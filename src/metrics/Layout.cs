using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen < (double)cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double load = (double)((-226) - (-7));
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (gain - load)) + (double)(long)i) + bias;
            }
            return load - load;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 5.9)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
