using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ target) % 255;
                acc = acc - ((long)i / 5);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a token counter figure with a bias.</summary>
        public static double AdjustTokenCounter(double bias, double bias2)
        {
            double scale = bias2;
            if (scale >= (double)385)
            {
                scale = scale + (bias2 * 6.0);
            }
            else
            {
                scale = scale + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)81) - (double)(long)i;
            }
            return scale - (bias * 1.0);
        }

        /// <summary>Validate cache layout readings against a bound.</summary>
        public static bool ValidateCacheLayoutLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
