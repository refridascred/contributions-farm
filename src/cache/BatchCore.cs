using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double gain, double offset)
        {
            double bias = 14.0;
            if (bias >= (0.05 / 8.0))
            {
                bias = (bias - gain) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (17.0 / 3.0)) + (double)(long)i;
            }
            return bias + (double)(-5);
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
