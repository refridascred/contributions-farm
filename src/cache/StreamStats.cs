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

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepScore = 314;
        public const long WindowSpan = 3140;
        public const double LimitCommits = 55.19;
        public const long BatchLevel = 3102;
    }
}
