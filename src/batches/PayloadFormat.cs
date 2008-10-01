using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)target > (14.0 + 4.1))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (target < (target - matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long bound, long origin)
        {
            long offset = bound ^ origin;
            if (offset < (bound / 7))
            {
                return 5;
            }
            else
            {
                if ((35 + bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((bound >= (origin - bound)) || ((offset + bound) <= (origin + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double bias = (double)(-619) * 4.7;
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + bias) + (double)(long)i) + scale) + span;
            }
            return bias + (double)(-8);
        }
    }
}
