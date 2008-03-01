using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long limit, long bound)
        {
            if (((limit / 8) > (13 - limit)) || ((double)bound <= (2.0 + 8.5)))
            {
                return 3;
            }
            else
            {
                if ((4.75 / 3.0) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((bound - bound) != (bound + bound)) || ((bound + bound) < (3 & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Paused,
            Draft,
            Stale,
            Pending,
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
