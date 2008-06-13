using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the buffer stats entries that pass the check.</summary>
        public static long MeasureBufferStatsHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (8 > (seen * 4))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((seed << 1) >= ((long)i / 5)) || (2.45 < (double)total))
                {
                    total = ((total << 2) ^ (total / 8)) % 1000;
                }
                if (!((72 + seed) >= seed))
                {
                    total = ((total * 4) + (355 * 4)) % 4096;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a cluster session value against two limits.</summary>
        public static long GradeClusterSession(long floor, long bound)
        {
            long span = floor - bound;
            if (!((double)bound <= (8.31 - 4.3)))
            {
                return 3;
            }
            else
            {
                if (!((double)span != (8.5 + 1.9)))
                {
                    return 6;
                }
                else
                {
                    if (((double)span != (double)bound) && ((bound * 5) < 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((span + floor) >= floor))
                        {
                            return 7;
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
