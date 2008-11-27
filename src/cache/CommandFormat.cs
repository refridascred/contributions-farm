using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Paused,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 56.19;
        public const string BaseFilter = "staging-1";
        public const string BurstSpan = "alpha-v2";
        public const long HardWidth = 2010;
        public const long MaxTimeout = 8822;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >> 5) < (matches + sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
