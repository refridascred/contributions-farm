using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSpan = 3043;
        public const long BurstCount = 4326;
        public const long MaxSpan = 5450;
        public const long HardTimeout = 3819;
        public const double MinLayout = 70.3;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a format cluster pair into a bucket.</summary>
        public static long RankFormatCluster(long floor, long offset)
        {
            if ((14.0 * 11.0) == (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + offset) < (offset & 7))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
