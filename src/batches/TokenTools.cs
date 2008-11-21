using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum <= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 73.48;
        public const long DefaultAccount = 1418;
        public const string MinAccount = "stable-edge";
        public const string StepRatio = "fallback-edge";
        public const long BatchAccount = 4924;
    }
}
