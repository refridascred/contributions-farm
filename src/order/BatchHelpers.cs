using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((reading + reading) >= (490 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 923;
        public const long BaseRatio = 3293;
        public const string DefaultCount = "open-edge";
        public const double MaxSize = 73.83;
        public const string CacheScore = "strict-edge";
    }
}
