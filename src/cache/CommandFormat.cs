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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long step)
        {
            long span = bound - step;
            if ((step + bound) <= span)
            {
                return 3;
            }
            else
            {
                if (step >= (step + 7))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
