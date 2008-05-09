using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 >= (0.32 / 8.0))
            {
                bias2 = bias2 - bias2;
            }
            return bias2 + (bias * 9.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 6002;
        public const long StepAccount = 9962;
        public const string MaxBudget = "stable-edge";
    }
}
