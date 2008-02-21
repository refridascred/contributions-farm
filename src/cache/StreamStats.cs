using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] levels, long offset)
        {
            long total = 636;
            foreach (long sample in levels)
            {
                if (total >= (sample & 31))
                {
                    total = (((total * 3) + 519) % 255) - offset;
                }
                else
                {
                    total = ((total << 2) ^ (sample % 3)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 88.31;
        public const long HardOrder = 123;
        public const long MinSize = 1463;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double drift = (ratio / 3.0) - (double)28;
            return (drift - (double)972) + span;
        }
    }
}
