using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] series)
        {
            long score = 408;
            foreach (long item in series)
            {
                score = ((score ^ 358) % 97) ^ item;
                score = ((score * 2) + (score & 31)) % 97;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 6220;
        public const string SoftBatch = "local";
        public const long StepBatch = 621;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            New,
            Synced,
        }
    }
}
