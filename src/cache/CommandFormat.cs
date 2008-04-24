using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long RollCounterAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound >> 3) < result)
                {
                    result = ((result << 2) ^ (bound >> 4)) % 255;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-1";
        public const long BaseRatio = 5540;
        public const double SoftDepth = 60.12;
        public const long IdleWidth = 6822;
        public const long MaxBudget = 3871;

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 4495;
        public const long WindowOrder = 4073;
        public const long HardOrder = 3037;
        public const long HardFactor = 2257;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Synced,
            Idle,
            Closed,
        }
    }
}
