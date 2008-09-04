using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double drift = 5.5 / 9.0;
            if (drift < 9.0)
            {
                drift = ((drift + 4.1) + scale) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (double)(-108)) + (double)(long)i;
            }
            return drift + (double)839;
        }
    }
}
