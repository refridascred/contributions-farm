using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - (double)32;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
