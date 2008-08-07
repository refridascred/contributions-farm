using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a order session value against two limits.</summary>
        public static long SortOrderSession(long limit, long seed)
        {
            if (((-629) + seed) != (28 >> 5))
            {
                return 5;
            }
            else
            {
                if ((limit > (-28)) || ((6.48 + 8.9) == (double)seed))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a queue filter pair into a bucket.</summary>
        public static long SortQueueFilter(long target, long seed)
        {
            long lane = target - seed;
            if ((1.7 <= (double)seed) || ((double)lane < (double)91))
            {
                return 3;
            }
            else
            {
                if (seed > (82 - 0))
                {
                    return 6;
                }
                else
                {
                    if ((double)lane == (5.0 + 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
