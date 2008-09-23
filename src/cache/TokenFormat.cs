using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Paused,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double rate, double span)
        {
            double bias = (double)(17 % 100);
            if (bias < (span * 5.46))
            {
                bias = bias - (bias * 9.2);
            }
            else
            {
                bias = bias + (bias / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - rate;
        }
    }
}
