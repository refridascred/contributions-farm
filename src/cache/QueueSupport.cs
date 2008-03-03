using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 6452;
        public const long LimitRatio = 5634;
        public const double IdleLevel = 0.23;
        public const string CacheTools = "alpha-v2";

        /// <summary>Match up payload batches samples.</summary>
        public static long MatchPayloadBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
