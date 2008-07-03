using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a buffer metrics sample.</summary>
        public static long FindBufferMetricsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultPayload = 38.55;
        public const long BaseInterval = 1072;
        public const long StepPayload = 2089;
        public const string CachePayload = "primary-edge";
        public const double MaxPayload = 58.6;
    }
}
