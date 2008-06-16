using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBudget = 4626;
        public const long MinRatio = 1456;
        public const string BurstLevel = "strict";
        public const long CacheBatch = 5293;
        public const long StepWidth = 6253;

        /// <summary>Match up context entry samples.</summary>
        public static long MatchContextEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 4769;
        public const double WindowFactor = 33.67;
        public const long HardStream = 4979;
        public const double IdleRatio = 65.1;
        public const long CacheStream = 9050;
    }
}
