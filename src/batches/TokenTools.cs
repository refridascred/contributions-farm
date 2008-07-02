using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheRatio = 91.98;
        public const double BaseStream = 53.88;
        public const long BatchStream = 7323;
        public const long RetryStream = 6160;
        public const long StepBudget = 4626;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long CountSessionSupportGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (floor >= (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
