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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long floor, long step)
        {
            long diff = floor - step;
            if ((double)diff != (7.1 / 6.0))
            {
                return 6;
            }
            else
            {
                if ((step - floor) > diff)
                {
                    return 8;
                }
                else
                {
                    if ((step * 4) < (1 / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(step < (50 ^ 384)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples)
        {
            long mix = 740;
            foreach (long value in samples)
            {
                mix = ((mix ^ (mix ^ 881)) % 97) ^ value;
            }
            return mix;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitSize = 7786;
        public const long MinSpan = 890;
        public const long MinCommand = 3918;

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
