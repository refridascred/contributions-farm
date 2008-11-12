using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepSize = 2350;
        public const long HardTimeout = 9535;
        public const string BurstTools = "open-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxBudget = "primary-edge";
        public const long DefaultRatio = 1192;
        public const string MinChannel = "alpha-v2";
        public const double HardChannel = 20.56;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
