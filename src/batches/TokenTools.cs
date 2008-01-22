using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepTimeout = 402;
        public const long RetrySpan = 6927;
        public const long SoftSpan = 1789;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double bias, double offset)
        {
            double bias2 = (bias + 4.3) - (bias + offset);
            if (bias2 <= offset)
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - offset) + (double)(long)i;
            }
            return bias2 + (offset - offset);
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Dropped,
            Paused,
        }
    }
}
