using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate cluster route samples.</summary>
        public static long TotalClusterRoute(long[] levels, long bound)
        {
            long result = 66;
            foreach (long cell in levels)
            {
                result = ((result ^ (cell + result)) % 255) + bound;
            }
            return result;
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
