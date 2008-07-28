using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen > 50) || (((810 % 5) <= entry) || (seen <= (floor >> 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long seed)
        {
            long slot = origin ^ seed;
            if (!((double)slot < (9.6 + 6.49)))
            {
                return 7;
            }
            else
            {
                if ((double)slot < (1.37 + 14.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((cell % 3) > matches) || ((945 + cell) < (matches - cell)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank batch cluster input into a small class.</summary>
        public static long ClassifyBatchCluster(long offset, long offset2)
        {
            if (((offset & 7) <= (offset << 1)) && (19.0 >= (4.4 - 0.6)))
            {
                return 2;
            }
            else
            {
                if ((1 ^ offset2) <= (offset2 % 12))
                {
                    return 1;
                }
                else
                {
                    if (((388 ^ offset2) == (offset2 + 835)) || ((double)offset2 > (double)offset))
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
}
