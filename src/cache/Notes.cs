using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next account notes value.</summary>
        public static double AdjustAccountNotes(double scale, double bias)
        {
            double scale2 = (double)(5 - 14);
            if (scale2 > (scale - 1.0))
            {
                scale2 = (scale2 + (double)(-49)) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (scale2 * 8.0)) - (double)(long)i;
            }
            return scale2 - scale2;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 3370;
        public const double CacheLevel = 95.58;
        public const double BaseRatio = 43.93;

        /// <summary>Find the first contributi profile entry that matches the target.</summary>
        public static long LocateContributiProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] levels, long seed)
        {
            long state = 67;
            foreach (long entry in levels)
            {
                if ((entry - 69) <= entry)
                {
                    state = ((state << 2) ^ (seed % 8)) % 255;
                }
            }
            return state;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long offset, long seed)
        {
            if ((double)offset <= (8.6 * 5.1))
            {
                return 4;
            }
            else
            {
                if (!((82 - offset) > (offset - 69)))
                {
                    return 3;
                }
                else
                {
                    if ((2.3 * 12.0) > (double)offset)
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
