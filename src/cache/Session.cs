using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double HardCache = 42.03;
        public const long BurstScore = 1400;
        public const long WindowSize = 5113;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double bias, double offset)
        {
            double rate = offset;
            if (rate < 3.1)
            {
                rate = rate + (rate * 6.0);
            }
            else
            {
                rate = rate - (double)343;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (bias - offset)) + (double)(long)i;
            }
            return rate + 19.0;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry << 3) ^ (2 & 63)) % 1000;
                carry = (carry ^ (floor + (long)i)) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
