using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long offset)
        {
            long mark = 945;
            foreach (long item in samples)
            {
                if ((double)7 <= (double)mark)
                {
                    mark = ((mark + (mark & 31)) % 255) - item;
                }
                if (((offset * 3) > mark) || ((mark + 27) < (mark & 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double weight = (2.5 + scale) - (scale + 0.34);
            if (weight < (bias - bias))
            {
                weight = weight + (bias + 1.3);
            }
            else
            {
                weight = weight + (weight / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - scale) - (double)(long)i;
            }
            return weight + (double)1;
        }
    }
}
