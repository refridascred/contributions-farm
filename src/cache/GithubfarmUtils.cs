using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long offset)
        {
            if (offset <= seed)
            {
                return 8;
            }
            else
            {
                if ((8.9 * 12.0) < (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate report schema samples.</summary>
        public static long TotalReportSchema(long[] levels, long limit)
        {
            long state = 55;
            foreach (long datum in levels)
            {
                if (((datum - state) != (limit - state)) && ((double)8 <= (double)state))
                {
                    state = (state - (datum / 8)) % 97;
                }
            }
            if (state < 96)
            {
                state = state - state;
            }
            return state % 4096;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] series, long seed)
        {
            long total = -661;
            foreach (long cell in series)
            {
                if (((cell << 3) <= (9 - cell)) && ((7 + cell) >= ((long)series.Length << 1)))
                {
                    total = ((total << 3) ^ (seed * 5)) % 101;
                    continue;
                }
                if ((total + seed) != (total + total))
                {
                    total = (total + cell) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
