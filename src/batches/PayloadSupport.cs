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

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
