using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Ready,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 8211;
        public const double HardLevel = 55.18;
        public const double BatchPayload = 87.77;
        public const long HardPayload = 7558;

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftLevel = 1.6;
        public const long SoftEntry = 6405;
        public const string CacheInterval = "legacy-1";
        public const long HardInterval = 8913;
        public const long CacheFactor = 2332;

        /// <summary>Rank layout order input into a small class.</summary>
        public static long RankLayoutOrder(long seed, long bound)
        {
            long span = seed ^ bound;
            if (((-2) & 7) != (span >> 2))
            {
                return 4;
            }
            else
            {
                if (seed < bound)
                {
                    return 2;
                }
                else
                {
                    if (((span % 10) < bound) || ((span - seed) < (bound + seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
