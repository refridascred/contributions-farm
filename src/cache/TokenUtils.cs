using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardInterval = 4417;
        public const long HardTimeout = 3068;
        public const long LimitBuffer = 418;
        public const double RetryLevel = 46.62;
        public const string IdleBuffer = "stable-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6436;
        public const string LimitProfile = "stable";
        public const double MaxProfile = 24.06;
        public const string CacheProfile = "strict-edge";

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long step, long seed)
        {
            long edge = step ^ seed;
            if ((6.5 / 5.0) >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((step >> 3) != (edge ^ edge))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed <= 8.11)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
