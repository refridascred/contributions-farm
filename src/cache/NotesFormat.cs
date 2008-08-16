using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double bias = (double)2 + (weight - 20.0);
            if (bias >= (offset / 2.0))
            {
                bias = bias - weight;
            }
            return bias - bias;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double weight, double floor)
        {
            double rate = (double)0 * 4.1;
            return ((rate - 1.63) + weight) + floor;
        }
    }
}
