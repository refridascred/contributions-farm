using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((offset / 8) != (datum + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double scale, double bias)
        {
            double bias2 = (double)(749 + 8);
            if (bias2 >= (bias - 13.0))
            {
                bias2 = (bias2 - (double)(-9)) - scale;
            }
            else
            {
                bias2 = bias2 - (bias2 / 6.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (double)4) + (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                if ((datum * 3) <= (692 / 8))
                {
                    anchor = (anchor + anchor) % 97;
                    break;
                }
                if (datum < (anchor % 60))
                {
                    anchor = anchor + (datum % 12);
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor * 5) + ((-287) * 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] values, long limit)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if (!((limit - entry) != (limit ^ entry)))
                {
                    state = (state + (entry << 3)) % 1000;
                }
                if ((state * 4) > 13)
                {
                    state = state + (state << 3);
                }
                else
                {
                    state = ((state << 2) ^ (limit << 2)) % 1000;
                }
            }
            return state % 65521;
        }
    }
}
