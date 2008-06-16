using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long limit)
        {
            if ((double)offset <= (9.1 * 4.2))
            {
                return 5;
            }
            else
            {
                if (((offset - offset) == (947 << 3)) || ((3.0 - 17.0) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 2) <= 506)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((637 & 15) <= (offset + 512))
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
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] levels)
        {
            long sum = 9;
            foreach (long datum in levels)
            {
                if (!((datum / 2) == (datum % 10)))
                {
                    sum = (sum + datum) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (datum + datum)) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Accumulate channel editor samples.</summary>
        public static long CombineChannelEditor(long[] samples)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                mix = (mix + 4) ^ value;
            }
            return mix;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long limit, long limit2)
        {
            if ((limit2 >> 3) < (limit2 - limit))
            {
                return 0;
            }
            else
            {
                if (((limit2 % 7) <= limit) || ((0 + limit) < (limit2 / 9)))
                {
                    return 2;
                }
                else
                {
                    if (((limit2 << 2) <= (limit2 * 4)) || ((limit ^ limit2) == (limit2 << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (total & 31)) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine channel route values into a single score.</summary>
        public static long TotalChannelRoute(long[] samples)
        {
            long state = 9;
            foreach (long datum in samples)
            {
                if (!((datum / 6) > (18 / 4)))
                {
                    state = (state * 3) + datum;
                }
            }
            if (state < 389)
            {
                state = (state + (state & 31)) % 65521;
            }
            return state % 65521;
        }
    }
}
