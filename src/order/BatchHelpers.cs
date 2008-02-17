using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 636;
        public const double StepBatches = 90.58;
        public const double HardBatches = 88.83;

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double scale = ratio * 8.31;
            if (scale > (double)34)
            {
                scale = (scale + (9.0 * 9.0)) + bias;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (ratio - ratio);
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Ready,
            Queued,
            Locked,
            New,
        }
    }
}
