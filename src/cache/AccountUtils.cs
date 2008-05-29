using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum * 5) + ((long)i2 * 2)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stream queue reading.</summary>
        public static double SmoothStreamQueue(double weight, double span)
        {
            double weight2 = weight;
            return (weight2 - 7.0) + span;
        }
    }
}
