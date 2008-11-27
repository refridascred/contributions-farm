using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a command notes sample.</summary>
        public static long FindCommandNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 6336;
        public const long HardDepth = 2936;
        public const long MaxDepth = 9774;
        public const long DefaultWidth = 3478;

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardRatio = 5947;
        public const long LimitCount = 8931;
        public const string HardWidth = "latest-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 9551;
        public const string SoftSpan = "legacy-edge";
        public const double LimitDepth = 97.85;
        public const long MinWidth = 1839;

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 16.14;
        public const long LimitStream = 9197;
        public const long SoftWidth = 6226;
        public const long DefaultStream = 6985;

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long MeasureReportCounterMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell << 1) != (338 << 2))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }
    }
}
