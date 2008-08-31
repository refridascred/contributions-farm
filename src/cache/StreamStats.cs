using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long seed)
        {
            if ((seed >> 5) == (seed / 9))
            {
                return 0;
            }
            else
            {
                if (((seed & 3) > (origin + seed)) || ((seed / 4) == (9 % 24)))
                {
                    return 3;
                }
                else
                {
                    if ((0.7 >= (double)origin) || ((seed % 60) <= (seed + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            New,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "staging-edge";
        public const string DefaultCluster = "stable-edge";
        public const string BaseTimeout = "legacy-1";
        public const string StepCluster = "primary-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheScore = "staging-1";
        public const long WindowFactor = 8792;
        public const long SoftChannel = 9938;
    }
}
