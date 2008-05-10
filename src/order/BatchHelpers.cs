using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double weight, double floor)
        {
            double ratio = floor * 10.0;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + floor) + (double)(long)i) - weight;
            }
            return ratio - ratio;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepRatio = "stable-1";
        public const double MaxProfile = 47.41;
        public const long WindowSpan = 7640;
        public const double IdleDepth = 57.41;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Retry,
            New,
        }
    }
}
