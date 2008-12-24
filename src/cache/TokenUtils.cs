using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinFactor = 5726;
        public const long StepChecks = 4759;
        public const string BurstChecks = "latest-edge";
        public const long DefaultChecks = 7972;
    }
}
