using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of route already readings.</summary>
        public static long WeighRouteAlready(long[] values, long floor)
        {
            long mix = 4;
            foreach (long cell in values)
            {
                if ((double)202 >= (double)mix)
                {
                    mix = ((mix << 3) ^ (floor + cell)) % 65521;
                }
            }
            if (mix > (-893))
            {
                mix = (mix * 3) + floor;
            }
            return mix;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double ratio = floor / 8.0;
            if (ratio <= (floor - weight))
            {
                ratio = ratio - (double)504;
            }
            return ratio - weight;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length > (1.02 / 7.0))
                {
                    matches = ((matches + 3) + item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= (double)280)
            {
                ratio = (ratio + (bias - ratio)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (ratio / 2.0);
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
