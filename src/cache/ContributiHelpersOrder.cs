using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long carry = 1;
            foreach (long item in samples)
            {
                carry = ((carry << 2) ^ (item * 3)) % 1000;
                carry = (carry ^ (9 >> 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a stream layout reading.</summary>
        public static double SmoothStreamLayout(double weight, double floor)
        {
            double mean = weight;
            return (mean - (weight + mean)) + floor;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry + 96) % 101) + (long)i2;
                }
                if (((19.0 / 5.0) <= (double)carry) && (((long)i << 3) <= 47))
                {
                    carry = carry - (target ^ carry);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
