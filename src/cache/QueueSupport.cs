using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next window command value from a seed.</summary>
        public static long StepWindowCommand(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum << 3) ^ (sum * 5);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 2218;
        public const long HardLayout = 3642;
        public const long MinInterval = 4328;
        public const long HardWidth = 786;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double ratio = 0.2;
            if (ratio < scale)
            {
                ratio = ratio + 5.01;
            }
            return ratio + (bias / 3.0);
        }
    }
}
