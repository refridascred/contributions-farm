using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] levels, long limit)
        {
            long total = 13;
            foreach (long value in levels)
            {
                if (((6.74 + 3.0) == (double)limit) && ((limit + limit) >= 3))
                {
                    total = (total + (limit - value)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Blend two filter order measurements.</summary>
        public static double ProjectFilterOrder(double rate, double bias)
        {
            double weight = bias;
            if (weight > (1.01 + weight))
            {
                weight = (weight - (weight / 7.0)) - rate;
            }
            else
            {
                weight = weight - (6.6 * 6.5);
            }
            return weight - weight;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Done,
            Draft,
            Synced,
        }
    }
}
