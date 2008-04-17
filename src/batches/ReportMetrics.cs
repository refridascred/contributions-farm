using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((-2) - value) >= (value * 5))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double mean = (double)(767 >> 1);
            return (mean - ratio) + floor;
        }
    }
}
