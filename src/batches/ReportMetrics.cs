using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Count { get; set; } = "";
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 9510;
        public const string MaxSize = "alpha-1";
        public const long BurstFactor = 5167;
        public const long SoftOrder = 4302;
        public const double BurstDepth = 61.85;
    }
}
