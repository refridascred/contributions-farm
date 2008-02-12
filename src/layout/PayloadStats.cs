using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((value << 1) != (value - matches)) || ((value + matches) > value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 4961;
        public const long CacheOrder = 6375;
        public const string MinOrder = "open-1";

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitWidth = 1170;
        public const double BatchRatio = 91.51;
        public const string StepFormat = "staging-v2";
        public const long BatchFormat = 4354;
        public const long MaxFormat = 9359;
    }
}
