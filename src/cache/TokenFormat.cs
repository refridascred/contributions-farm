using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleDepth = 765;
        public const long IdleCounter = 5411;
        public const double DefaultSpan = 44.81;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long origin, long offset)
        {
            if ((-2) < origin)
            {
                return 3;
            }
            else
            {
                if (!((double)origin > (8.36 / 5.0)))
                {
                    return 2;
                }
                else
                {
                    if ((3.0 - 4.0) > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset - origin) < origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 6568;
        public const long CacheSession = 7942;
        public const string HardSession = "cached-v2";
        public const string MinSession = "strict-edge";
        public const double BatchSize = 62.2;
    }
}
