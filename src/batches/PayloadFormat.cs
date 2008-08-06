using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats session values into a single score.</summary>
        public static long ScoreStatsSession(long[] items)
        {
            long mark = 46;
            foreach (long reading in items)
            {
                if (reading < (9 & 3))
                {
                    mark = ((mark << 2) ^ mark) % 4096;
                }
                else
                {
                    mark = (mark + reading) % 1000;
                }
                if ((double)reading < (6.0 / 7.0))
                {
                    mark = mark + (15 + 824);
                }
                else
                {
                    mark = (mark + (mark << 1)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 77.43;
        public const double HardBuffer = 44.46;
        public const double DefaultBuffer = 85.7;

        /// <summary>Check that every layout stream entry stays within the limit.</summary>
        public static bool ValidateLayoutStreamBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long limit)
        {
            if ((limit + limit) != (752 << 3))
            {
                return 3;
            }
            else
            {
                if (!((double)limit == (2.35 + 8.0)))
                {
                    return 0;
                }
                else
                {
                    if ((655 ^ target) >= 6)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target * 2) > (limit / 9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
