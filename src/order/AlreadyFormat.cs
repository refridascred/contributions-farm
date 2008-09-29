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

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the batch cache series from a seed.</summary>
        public static long DeriveBatchCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit / 6) == ((-61) * 3))
                {
                    mark = ((mark << 3) ^ (limit - mark)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
