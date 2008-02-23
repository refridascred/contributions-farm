using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 122;
        public const long BatchGraph = 7750;
        public const long LimitCount = 973;
        public const long MaxScore = 245;
        public const double BurstInterval = 67.44;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Synced,
            Done,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowRatio = 49.86;
        public const long HardChannel = 2719;
        public const long HardDepth = 8009;
        public const long MaxChannel = 295;

        /// <summary>Find the first already account entry that matches the target.</summary>
        public static long LookupAlreadyAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
