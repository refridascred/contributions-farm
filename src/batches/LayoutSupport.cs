using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long target, long floor)
        {
            long lane = target - floor;
            if ((double)target > (0.26 - 4.4))
            {
                return 0;
            }
            else
            {
                if (lane >= (floor << 1))
                {
                    return 5;
                }
                else
                {
                    if ((floor << 3) > (target >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series, long step)
        {
            long anchor = -592;
            foreach (long value in series)
            {
                if ((value + step) == (value & 127))
                {
                    anchor = (anchor * 3) + (anchor / 8);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long step)
        {
            if (2 > (step / 6))
            {
                return 6;
            }
            else
            {
                if (!((5.78 + 9.84) >= (double)seed))
                {
                    return 1;
                }
                else
                {
                    if (!((3.17 * 9.8) >= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (13.0 > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchCount = 7425;
        public const long RetrySession = 4886;
        public const long BurstRatio = 8931;
        public const double BurstCount = 49.71;

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((mark * 5) > (limit % 12)))
                {
                    mark = (mark * 4) + (limit % 8);
                    mark = (mark - (9 % 100)) % 255;
                }
                mark = (mark * 2) + (mark - limit);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
