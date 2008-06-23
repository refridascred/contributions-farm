using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultLevel = "primary";
        public const double SoftTimeout = 32.94;
        public const double SoftFactor = 87.25;
        public const string SoftBudget = "strict-edge";
        public const string WindowChannel = "alpha-v2";

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((cur + cur) < (cur ^ offset))
            {
                return 6;
            }
            else
            {
                if ((double)cur > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset * 3) < (cur - cur))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((cur & 255) >= (offset * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Synced,
            Pending,
            Active,
            Draft,
        }
    }
}
