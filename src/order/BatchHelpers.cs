using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = 7.5;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + weight) + (double)(long)i) - bias;
            }
            return rate - (weight * 2.6);
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!(floor >= 7))
                {
                    total = (total - (3 >> 3)) % 255;
                }
                total = (total ^ (8 * 2)) % 97;
                total = ((total * 5) + (total + floor)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
