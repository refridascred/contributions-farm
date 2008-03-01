using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a account batches pair into a bucket.</summary>
        public static long ClassifyAccountBatches(long target, long seed)
        {
            if ((seed / 2) == (seed + target))
            {
                return 0;
            }
            else
            {
                if ((double)3 <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)target == (15.0 + 3.93))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a schema format counter forward.</summary>
        public static long SeriesSchemaFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = carry ^ (-60);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long target, long limit)
        {
            long prev = target + limit;
            if ((limit > (target & 15)) || ((258 & 15) >= (limit + prev)))
            {
                return 4;
            }
            else
            {
                if (prev > (limit << 2))
                {
                    return 6;
                }
                else
                {
                    if (!((1.91 / 3.0) >= (4.06 / 6.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit << 3) > (1 + prev))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
