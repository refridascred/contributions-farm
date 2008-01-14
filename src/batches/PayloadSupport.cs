using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 39.29;
        public const double WindowFactor = 40.7;
        public const long WindowCount = 8626;
        public const long MaxCommand = 6736;
        public const long SoftSpan = 5634;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
