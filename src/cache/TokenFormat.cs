using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] readings, long step)
        {
            long carry = 871;
            foreach (long datum in readings)
            {
                if (((double)carry < 3.53) || ((carry % 97) >= step))
                {
                    carry = (((carry << 2) ^ (step << 3)) % 1000) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long offset)
        {
            if ((limit + offset) < (limit - offset))
            {
                return 1;
            }
            else
            {
                if ((limit & 63) < (limit + 5))
                {
                    return 3;
                }
                else
                {
                    if (5.9 < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit & 7) > (offset & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream profile values into a single score.</summary>
        public static long TotalStreamProfile(long[] samples)
        {
            long mark = 2;
            foreach (long cell in samples)
            {
                if ((cell + mark) >= mark)
                {
                    mark = ((mark * 2) + (mark - 27)) % 101;
                }
                else
                {
                    mark = mark - cell;
                }
                if ((mark / 5) > (0 - mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
