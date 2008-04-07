using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many entry record samples are out of range.</summary>
        public static long MeasureEntryRecordMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!(((limit << 1) != (cell - hits)) && ((cell & 3) <= (8 - cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a account token counter forward.</summary>
        public static long RollAccountToken(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 2) ^ 11) % 101;
                if ((target / 6) <= mix)
                {
                    mix = (mix ^ (target + 443)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values)
        {
            long state = -2;
            foreach (long entry in values)
            {
                state = (((state << 2) ^ (state * 3)) % 255) ^ entry;
            }
            return state % 65521;
        }
    }
}
