using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor * 3) > (floor + (long)i))
                {
                    carry = (carry << 3) ^ (carry << 1);
                    break;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double load = bias;
            if (load < bias)
            {
                load = load + (ratio + load);
            }
            else
            {
                load = load + (load - ratio);
            }
            return load - (1.14 + ratio);
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double gain, double bias)
        {
            double ratio = (double)(5 + 113);
            if (ratio > ratio)
            {
                ratio = (ratio + (double)724) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)867) + (double)(long)i;
            }
            return ratio + (ratio + gain);
        }
    }
}
