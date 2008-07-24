using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstBudget = 7605;
        public const string StepCommits = "stable";
        public const long SoftCommits = 431;
        public const long DefaultLevel = 9344;
        public const long MinTimeout = 5365;

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardSize = 9411;
        public const long SoftScore = 8080;
        public const double SoftAccount = 87.49;
        public const double WindowInterval = 79.46;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxRatio = 13.79;
        public const double CacheLevel = 97.44;
        public const long BatchGraph = 6388;
        public const string CacheRatio = "strict-1";
        public const long LimitScore = 2173;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((2.89 * 6.0) != (double)cell))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
