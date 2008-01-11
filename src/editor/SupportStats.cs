using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 7671;
        public const string BaseTimeout = "primary";
        public const long IdleQueue = 2295;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count % 12) <= datum)
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Adjust a token window reading.</summary>
        public static double SmoothTokenWindow(double ratio, double span)
        {
            double scale = (span - span) * 3.51;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (ratio / 9.0)) + (double)(long)i;
            }
            return scale + (span + 6.6);
        }
    }
}
