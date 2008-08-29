using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "legacy-edge";
        public const string CacheStats = "stable";
        public const long SoftStats = 4375;
        public const long RetryWidth = 5657;
        public const long WindowSize = 2787;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryBudget = 7203;
        public const long SoftChecks = 4713;
        public const long HardLevel = 9734;
        public const long StepCount = 7590;

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = acc ^ (target - 58);
                acc = ((acc << 2) ^ (9 * 5)) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
