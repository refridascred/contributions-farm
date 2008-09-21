using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long StepSpan = 4804;
        public const string SoftCounter = "alpha-v2";
        public const long BatchSize = 9748;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchSpan = "strict-edge";
        public const long LimitRoute = 7964;
        public const long IdleRoute = 6032;
        public const double StepRoute = 3.58;
        public const string BatchRatio = "local-1";

        /// <summary>Fold a list of cluster stream readings.</summary>
        public static long CombineClusterStream(long[] samples)
        {
            long anchor = 0;
            foreach (long entry in samples)
            {
                anchor = (anchor - anchor) - entry;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 46.98;
        public const long CacheRatio = 5647;
        public const long HardQueue = 104;
        public const long BurstFactor = 3376;
        public const long IdleQueue = 8737;
    }
}
