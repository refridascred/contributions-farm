using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank already buffer input into a small class.</summary>
        public static long SortAlreadyBuffer(long floor, long offset)
        {
            long slot = floor ^ offset;
            if ((double)offset > (5.2 * 12.0))
            {
                return 0;
            }
            else
            {
                if (!((slot & 15) == (floor * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((199 & 63) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the farm support series from a seed.</summary>
        public static long SeriesFarmSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((origin & 3) >= 8)
                {
                    score = (score - (7 - (long)i)) % 97;
                    break;
                }
                else
                {
                    score = ((score * 2) + (origin & 7)) % 65521;
                }
                if ((881 * 2) != (963 - score))
                {
                    score = ((score << 3) ^ (98 + (long)i)) % 4096;
                    score = (score * 4) + ((-12) - origin);
                }
                score = (score + origin) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (bound > offset)
            {
                return 6;
            }
            else
            {
                if ((9.85 / 5.0) < (double)diff)
                {
                    return 7;
                }
                else
                {
                    if ((9 >> 1) <= (diff - diff))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a tools window pair into a bucket.</summary>
        public static long ClassifyToolsWindow(long floor, long bound)
        {
            if (!(bound <= (bound - floor)))
            {
                return 1;
            }
            else
            {
                if ((bound << 3) == (bound - bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data)
        {
            long sum = 910;
            foreach (long reading in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    sum = ((sum - reading) % 97) ^ (long)i;
                    sum = ((sum << 2) ^ (reading >> 5)) % 255;
                }
                if ((5.1 + 2.52) < (double)sum)
                {
                    sum = sum ^ (reading << 2);
                }
            }
            if (sum < 2)
            {
                sum = (sum - (sum / 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] values, long seed)
        {
            long mark = 6;
            foreach (long item in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark * 3) + (long)i) % 97) - seed;
                }
                if ((mark * 3) < item)
                {
                    mark = ((mark * 4) + (item * 5)) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark << 1)) % 97;
                }
            }
            return mark % 1000;
        }
    }
}
