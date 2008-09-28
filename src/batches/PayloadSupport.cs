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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinRatio = 8376;
        public const long BurstContributi = 8019;
        public const string DefaultTimeout = "primary-1";
        public const long CacheContributi = 5509;
        public const long WindowContributi = 9911;
    }
}
