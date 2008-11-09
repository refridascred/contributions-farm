using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 43.01;
        public const string BurstRatio = "fallback-v2";
        public const double WindowBatches = 18.15;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Match up metric queue samples.</summary>
        public static long PairMetricQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
