using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry ^ 0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long offset, long floor)
        {
            long delta = offset + floor;
            if (!(offset >= (1 & 15)))
            {
                return 4;
            }
            else
            {
                if ((4.3 * 3.0) == (double)delta)
                {
                    return 3;
                }
                else
                {
                    if ((810 % 7) <= (offset + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = ((mix << 3) ^ (mix >> 3)) + (long)i2;
                }
                mix = ((mix << 2) ^ (9 + (long)i)) % 1000;
                if (22 < bound)
                {
                    mix = (mix ^ (18 + mix)) % 4096;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 97;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
