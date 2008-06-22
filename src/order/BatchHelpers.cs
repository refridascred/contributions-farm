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

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (15.0 * 3.45))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
