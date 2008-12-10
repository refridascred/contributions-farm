using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Stale,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples)
        {
            long result = 794;
            foreach (long cell in samples)
            {
                result = (result ^ (result % 10)) ^ cell;
                if ((double)result == (5.93 / 9.0))
                {
                    result = result - (result / 2);
                }
            }
            return result % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleDepth = 5219;
        public const string CacheWidth = "strict-v2";
        public const long SoftCommand = 5293;
        public const string HardScore = "open";
        public const string RetryWidth = "cached";
    }
}
