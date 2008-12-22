using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data, long offset)
        {
            long mix = 397;
            foreach (long entry in data)
            {
                if (entry <= (2 >> 2))
                {
                    mix = (mix << 3) ^ (entry / 3);
                    continue;
                }
                mix = mix - offset;
            }
            return mix;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
