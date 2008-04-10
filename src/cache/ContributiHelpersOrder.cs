using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 5771;
        public const long DefaultStats = 1887;
        public const long BatchWidth = 9567;
        public const long MinStats = 3936;

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double bias2 = 3.52 * 4.3;
            if (bias2 <= 3.52)
            {
                bias2 = (bias2 + (rate + 20.0)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (19.0 * 2.0)) + (double)(long)i;
            }
            return bias2 - 6.0;
        }
    }
}
