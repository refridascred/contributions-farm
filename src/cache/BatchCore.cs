using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Blend two layout metric measurements.</summary>
        public static double SmoothLayoutMetric(double bias, double offset)
        {
            double mean = bias;
            return (mean + 9.89) + offset;
        }
    }
}
