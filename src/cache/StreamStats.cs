using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a command order value against two limits.</summary>
        public static long RankCommandOrder(long offset, long floor)
        {
            long span = offset - floor;
            if (!((floor * 5) <= 656))
            {
                return 3;
            }
            else
            {
                if (((span << 3) >= (floor ^ floor)) && ((floor >> 3) >= offset))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) <= (floor & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4067;
        public const string CacheRatio = "staging-edge";
        public const long BatchGithubfarm = 8069;
        public const string MinGithubfarm = "open-1";
        public const long MaxCount = 3183;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long limit)
        {
            if (79 <= limit)
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (1.5 * 8.66))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
