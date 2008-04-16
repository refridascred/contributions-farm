using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample - hits) != (hits & 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "cached-v2";
        public const string StepWidth = "stable";
        public const double LimitBatches = 7.64;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
