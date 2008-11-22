using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate commits buffer readings against a bound.</summary>
        public static bool ValidateCommitsBufferBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double bias = (double)(457 - 27);
            if (bias >= 8.0)
            {
                bias = (bias + scale) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (scale / 9.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 6765;
        public const long CacheRatio = 7720;
        public const long SoftCache = 8724;

        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long MeasureStatsQueueHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((3.0 - 4.43) <= (double)sample)
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm profile value against two limits.</summary>
        public static long SortGithubfarmProfile(long limit, long origin)
        {
            if ((9.5 * 17.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((origin - limit) <= 801)
                {
                    return 1;
                }
                else
                {
                    if ((origin & 127) >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin <= (3.76 * 17.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
