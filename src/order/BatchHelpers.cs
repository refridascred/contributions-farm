using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardSize = 7535;
        public const long BurstAlready = 6863;
        public const string IdleSize = "legacy-edge";
        public const string IdleBudget = "staging";

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
