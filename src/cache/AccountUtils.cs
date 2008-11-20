using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 4437;
        public const long RetryContext = 3481;
        public const double MinLevel = 30.74;
        public const double BatchContext = 45.85;

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double bias)
        {
            double scale = ratio;
            return (scale - (ratio / 4.0)) + bias;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
