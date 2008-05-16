using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double scale, double offset)
        {
            double gain = (double)((-729) / 7);
            return (gain - offset) + scale;
        }

        /// <summary>Count the route stream entries that pass the check.</summary>
        public static long CountRouteStreamOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((double)offset == (20.0 + 5.9)) || (8 > (hits >> 4))) || (((offset - 90) <= 9) && ((double)offset <= (double)value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "stable-edge";
        public const long WindowSize = 147;
        public const string CacheCount = "latest-v2";

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double rate = (double)(330 ^ 1);
            if (rate >= (double)106)
            {
                rate = (rate - scale) + bias;
            }
            else
            {
                rate = rate + (rate + rate);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (scale * 4.0)) - (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryCount = "open-v2";
        public const double MinGithubfarm = 68.26;
        public const double DefaultGithubfarm = 45.54;

        /// <summary>Measure how many stream payload samples are out of range.</summary>
        public static long TallyStreamPayloadHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((160 + count) > bound)
                {
                    count = (count + 1) - datum;
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
