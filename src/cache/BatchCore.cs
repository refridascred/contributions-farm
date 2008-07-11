using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count < (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a counter format figure with a bias.</summary>
        public static double BlendCounterFormat(double weight, double floor)
        {
            double bias = (double)((-54) >> 3);
            if (bias > weight)
            {
                bias = bias - weight;
            }
            else
            {
                bias = bias + (double)203;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (floor * 4.3)) + (double)(long)i;
            }
            return bias + floor;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
