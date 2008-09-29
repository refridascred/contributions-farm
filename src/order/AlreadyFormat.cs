using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 16.75;
        public const long MaxDepth = 2641;
        public const long BurstRatio = 4494;
        public const string HardStream = "primary-edge";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long offset, long origin)
        {
            long prev = offset + origin;
            if (((double)offset == (4.06 - 16.0)) || ((94 % 16) >= (origin ^ prev)))
            {
                return 1;
            }
            else
            {
                if (((prev ^ prev) > (offset / 7)) && ((double)prev > (9.9 + 15.0)))
                {
                    return 2;
                }
                else
                {
                    if ((prev - prev) < (origin + prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a profile schema value against two limits.</summary>
        public static long GradeProfileSchema(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((cur / 5) >= 70)
            {
                return 2;
            }
            else
            {
                if ((51 ^ 749) <= (floor + 750))
                {
                    return 5;
                }
                else
                {
                    if ((seed + cur) <= (seed % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)cur >= (3.9 + 6.3))
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

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 6782;
        public const long SoftCount = 5630;
        public const long BaseInterval = 3474;
        public const long CacheSize = 4063;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Active,
            Idle,
            Failed,
            Queued,
        }
    }
}
