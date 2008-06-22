using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseLevel = "primary-edge";
        public const long SoftWidth = 1536;
        public const double HardBatches = 84.4;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Done,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] data, long limit)
        {
            long mix = 96;
            foreach (long item in data)
            {
                if (!((limit >> 2) == ((long)data.Length / 4)))
                {
                    mix = mix ^ item;
                }
            }
            return mix;
        }
    }
}
