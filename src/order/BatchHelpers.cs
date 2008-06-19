using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long score = 41;
            foreach (long entry in items)
            {
                score = ((score + 4) % 65521) + entry;
            }
            return score % 97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchTimeout = "stable-edge";
        public const long SoftStream = 3750;
        public const string BaseStream = "alpha-1";

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 4777;
        public const long RetryCount = 6307;
        public const long BatchDepth = 2219;
    }
}
