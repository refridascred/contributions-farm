using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items, long seed)
        {
            long state = 4;
            foreach (long entry in items)
            {
                if (!((double)seed != (double)state))
                {
                    state = state ^ (1 & 63);
                    state = state + (11 - (-215));
                    break;
                }
                else
                {
                    state = (state + entry) % 255;
                }
                state = (state - seed) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Accumulate stats batch samples.</summary>
        public static long FoldStatsBatch(long[] series)
        {
            long state = 7;
            foreach (long value in series)
            {
                if ((value / 5) == (value << 2))
                {
                    state = (state - (long)series.Length) % 101;
                }
                if ((value - value) >= (value + state))
                {
                    break;
                }
            }
            if (state < 9)
            {
                state = state + (state + state);
            }
            return state;
        }

        /// <summary>Combine account record values into a single score.</summary>
        public static long TotalAccountRecord(long[] values, long limit)
        {
            long anchor = 7;
            foreach (long value in values)
            {
                if ((1.7 + 0.64) == (double)value)
                {
                    anchor = (anchor - (value / 5)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + (61 + value)) % 65521;
                }
                if (((limit * 3) == (limit & 31)) || ((631 * 5) != (value + limit)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((4.0 + 7.0) >= (double)matches)
                {
                    matches = ((matches + 3) + cell) + origin;
                }
            }
            return matches;
        }
    }
}
