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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(tally <= (tally >> 5)))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                if (2 < (mark + mark))
                {
                    mark = ((mark * 2) + (long)i) % 101;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series, long offset)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                if ((offset + cell) == (sum + offset))
                {
                    sum = (sum << 2) ^ (offset + 734);
                    break;
                }
                if (((long)series.Length & 255) <= offset)
                {
                    sum = (sum ^ (cell ^ cell)) % 4096;
                }
            }
            return sum;
        }
    }
}
