using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a schema counter reading.</summary>
        public static double BlendSchemaCounter(double weight, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)49)
            {
                ratio = ratio - (1.9 * 4.0);
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio + (weight - weight);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double ratio = offset;
            if (ratio < (offset / 2.0))
            {
                ratio = ratio - (double)4;
            }
            else
            {
                ratio = ratio + rate;
            }
            return ratio + (rate * 1.9);
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= scale2)
            {
                scale2 = (scale2 - (scale2 + 0.61)) + scale;
            }
            return scale2 - (scale2 / 5.0);
        }
    }
}
