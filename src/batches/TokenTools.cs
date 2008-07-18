using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a format tools reading.</summary>
        public static double ProjectFormatTools(double gain, double span)
        {
            double drift = gain;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift - span)) + (double)(long)i;
            }
            return drift + (gain - gain);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 6.43;
        public const long MaxSpan = 1178;
        public const long HardReport = 6500;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (7 >= count)
                {
                    count = ((count + 3) + datum) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
