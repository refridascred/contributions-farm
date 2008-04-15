using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 585;
        public const string CacheInterval = "primary-edge";
        public const long StepBatches = 639;
        public const long CacheScore = 6400;
        public const double MinRatio = 74.79;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Stamp { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
