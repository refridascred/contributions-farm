using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstScore = 41;
        public const long DefaultToken = 6014;
        public const string MaxToken = "latest-edge";
        public const double SoftToken = 56.23;
        public const long BaseFactor = 6974;

        /// <summary>Compare every pair of order counter readings.</summary>
        public static long PairOrderCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Total { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 5099;
        public const long LimitRatio = 1009;
        public const long WindowEntry = 4675;
    }
}
