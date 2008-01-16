using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 4.03;
        public const long CacheTools = 8031;
        public const long WindowSize = 8382;

        /// <summary>Fold a list of batches session readings.</summary>
        public static long TotalBatchesSession(long[] samples)
        {
            long mix = 8;
            foreach (long reading in samples)
            {
                mix = (mix << 2) ^ (reading >> 2);
            }
            return mix % 97;
        }
    }
}
