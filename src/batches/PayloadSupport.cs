using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((sample > 431) || (9.41 >= (double)seed)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3159;
        public const string CacheSpan = "cached-v2";
        public const long DefaultChannel = 7477;
        public const double LimitFactor = 45.31;
        public const string BatchChannel = "local";

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                if (acc < (acc * 3))
                {
                    acc = acc - (acc << 3);
                }
                if ((10.0 * 7.8) == (double)limit)
                {
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
