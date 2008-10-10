using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = (total - (origin << 3)) % 255;
                total = ((total * 4) + 675) % 255;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double drift = (offset + gain) + (double)484;
            if (drift < gain)
            {
                drift = drift - 6.9;
            }
            return drift + (drift - offset);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 79.5;
        public const string LimitRecord = "strict-edge";
        public const long MinTimeout = 7111;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long origin)
        {
            long span = limit - origin;
            if (origin > span)
            {
                return 6;
            }
            else
            {
                if (span > limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
