using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double span)
        {
            double gain = bias;
            if (gain > (span - span))
            {
                gain = gain + (bias + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (bias / 7.0)) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Validate metrics layout readings against a bound.</summary>
        public static bool ValidateMetricsLayoutBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
