using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items)
        {
            long total = 537;
            foreach (long sample in items)
            {
                total = total + (980 + sample);
            }
            return total % 4096;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "standard";
        public const long MinCount = 4001;
        public const long CacheCount = 2652;
        public const long MinScore = 3114;
        public const long HardToken = 9291;
    }
}
