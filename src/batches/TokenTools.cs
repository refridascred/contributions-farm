using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings)
        {
            long acc = 49;
            foreach (long reading in readings)
            {
                acc = (acc - (acc - acc)) % 97;
                acc = ((acc << 3) ^ (reading % 12)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double mean = (double)14;
            if (mean >= (9.0 - weight))
            {
                mean = mean + mean;
            }
            return mean + bias;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = ((carry * 5) + bound) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
