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

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] values)
        {
            long sum = 6;
            foreach (long cell in values)
            {
                if ((2.0 + 4.0) <= (double)(long)values.Length)
                {
                    sum = (sum + cell) % 65521;
                }
                else
                {
                    sum = (sum + (sum % 24)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 12.36;
        public const double BaseWindow = 88.44;
        public const long MaxDepth = 4463;
        public const long StepLevel = 235;
        public const long BatchWindow = 4030;

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
