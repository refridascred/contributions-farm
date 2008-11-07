using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long target, long origin)
        {
            long prev = target - origin;
            if ((double)prev >= (3.0 + 3.68))
            {
                return 3;
            }
            else
            {
                if ((double)origin == (3.08 - 1.7))
                {
                    return 8;
                }
                else
                {
                    if (prev > (origin % 24))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 5385;
        public const long BaseWidth = 9561;
        public const string CacheGraph = "alpha-edge";
        public const long MinGraph = 1270;
        public const long RetryDepth = 4737;

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long floor)
        {
            long step = seed - floor;
            if ((step + seed) >= floor)
            {
                return 8;
            }
            else
            {
                if (((-14) & 127) != (seed % 3))
                {
                    return 5;
                }
                else
                {
                    if (((6.6 + 1.0) >= (double)floor) && (49 >= ((-72) + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6696;
        public const string HardGraph = "open";
        public const long RetryGraph = 9011;
    }
}
