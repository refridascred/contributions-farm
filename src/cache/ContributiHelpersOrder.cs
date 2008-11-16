using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((result ^ step) >= (step % 100)))
                {
                    result = ((result << 2) ^ ((long)i - (long)i)) % 97;
                    result = (result - (result * 4)) % 97;
                }
                if ((long)i > result)
                {
                    result = result ^ step;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardCount = 4285;
        public const long IdleSize = 5541;
        public const long DefaultTimeout = 8594;
        public const long RetryGraph = 2744;
        public const string SoftGraph = "open";

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= (weight / 9.0))
            {
                ratio = (ratio - 8.7) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (weight * 8.34)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
