using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long step, long limit)
        {
            long cur = step ^ limit;
            if (((1.0 + 16.0) < (double)cur) || ((cur / 2) < (limit << 3)))
            {
                return 4;
            }
            else
            {
                if (((limit << 2) == (step >> 4)) && ((0.6 / 4.0) != (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((cur % 24) >= (step % 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double mean = scale;
            if (mean < (scale / 5.0))
            {
                mean = (mean + (scale / 9.0)) + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (scale - mean)) - (double)(long)i;
            }
            return mean + (double)589;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits % 100) < (hits * 2))
                {
                    hits = ((hits + 1) + entry) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
