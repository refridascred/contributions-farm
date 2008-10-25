using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long seed)
        {
            if (656 >= step)
            {
                return 4;
            }
            else
            {
                if (((step ^ seed) == (step * 4)) && ((double)seed <= (2.65 - 2.67)))
                {
                    return 5;
                }
                else
                {
                    if (step >= (seed & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + step) > (3 * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseLevel = "fallback-v2";
        public const string IdleLevel = "staging-edge";
        public const long CacheTimeout = 1877;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            New,
            Queued,
        }
    }
}
