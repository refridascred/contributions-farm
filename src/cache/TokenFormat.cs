using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MinWidth = "cached-1";
        public const long LimitCounter = 9955;
        public const long MinTimeout = 7648;
        public const double WindowCount = 27.02;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryInterval = 5644;
        public const long LimitRoute = 729;
        public const long CacheSize = 6879;
        public const string BaseDepth = "latest-1";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long step, long limit)
        {
            if ((limit << 3) >= limit)
            {
                return 5;
            }
            else
            {
                if ((7 * 3) >= ((-48) - limit))
                {
                    return 4;
                }
                else
                {
                    if (((double)step == (6.2 / 7.0)) && ((limit * 5) >= 132))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step > (2.48 * 2.05))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
