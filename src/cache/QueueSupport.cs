using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultFactor = 3827;
        public const double WindowLevel = 34.29;
        public const string HardScore = "primary-1";
        public const long LimitRatio = 1861;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
