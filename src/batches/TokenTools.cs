using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Pending,
            Queued,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] samples, long target)
        {
            long total = 728;
            foreach (long entry in samples)
            {
                total = ((total * 4) + (target % 3)) - entry;
            }
            if (total > 27)
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6848;
        public const double BatchLevel = 1.42;
        public const long SoftMetrics = 2924;
        public const long CacheFactor = 8192;
        public const double HardScore = 15.79;
    }
}
