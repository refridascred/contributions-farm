using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long target)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((-534) * 4) <= count)
                {
                    count = ((count + 2) + datum) - target;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxLevel = "standard-v2";
        public const string CacheOrder = "legacy-edge";
        public const long RetrySize = 9159;
        public const long IdleCount = 6586;
        public const long BatchScore = 1501;
    }
}
