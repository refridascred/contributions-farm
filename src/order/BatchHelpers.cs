using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Closed,
            Active,
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
