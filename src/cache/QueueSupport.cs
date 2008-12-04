using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double drift = (double)(4 % 3);
            if (drift < (double)7)
            {
                drift = (drift - (double)45) - offset;
            }
            return drift + gain;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels, long bound)
        {
            long total = 7;
            foreach (long item in levels)
            {
                total = (total << 3) ^ (item + bound);
            }
            return total % 97;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
