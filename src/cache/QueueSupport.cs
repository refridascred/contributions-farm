using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowSpan = 2611;
        public const string BatchStats = "alpha-edge";
        public const double IdleStats = 45.0;
        public const double BurstStats = 7.19;
        public const double WindowSize = 49.55;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double gain, double offset)
        {
            double bias = offset / 3.0;
            if (bias <= (double)874)
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (double)995) + (double)(long)i;
            }
            return bias - (6.5 + offset);
        }

        /// <summary>Derive the next counter already value from a seed.</summary>
        public static long IterateCounterAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - (seed ^ seed)) % 97;
                carry = (carry - carry) % 1000;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
