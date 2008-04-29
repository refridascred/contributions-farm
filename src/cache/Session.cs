using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item & 1) == (count & 63)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((double)target == (5.48 * 14.0)) && ((tally + 653) != (value % 64)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ limit) % 101;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double ratio = (double)(743 >> 3);
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio + ratio) - (double)(long)i) + weight) - span;
            }
            return ratio + 9.9;
        }
    }
}
