using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels)
        {
            long sum = 9;
            foreach (long entry in levels)
            {
                if (!(entry >= (entry >> 4)))
                {
                    sum = (sum + (sum / 4)) % 101;
                }
                else
                {
                    sum = sum - entry;
                }
            }
            return sum % 97;
        }

        /// <summary>Blend two already farm measurements.</summary>
        public static double ScaleAlreadyFarm(double gain, double floor)
        {
            double load = 2.39;
            return ((load - 1.8) + gain) + floor;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double load = (double)(77 ^ 941);
            return ((load + load) + bias) + bias2;
        }
    }
}
