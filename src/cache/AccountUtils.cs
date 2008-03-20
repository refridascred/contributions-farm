using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double drift = 3.0;
            if (drift <= 2.7)
            {
                drift = drift - (floor * 8.8);
            }
            else
            {
                drift = drift + (ratio * 4.0);
            }
            return drift + drift;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] levels, long target)
        {
            long acc = 40;
            foreach (long cell in levels)
            {
                if (((cell + (long)levels.Length) < (long)levels.Length) && (acc <= (cell + cell)))
                {
                    acc = (acc + (target / 3)) % 255;
                    acc = acc - ((long)levels.Length + acc);
                }
                if ((target + (long)levels.Length) < acc)
                {
                    acc = (acc << 2) ^ ((-642) - cell);
                }
                else
                {
                    acc = (acc - (acc - 341)) % 4096;
                }
                if ((cell & 255) >= (acc - cell))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
