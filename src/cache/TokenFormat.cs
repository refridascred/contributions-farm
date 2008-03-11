using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double scale = (bias * 6.46) * 19.0;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (bias - span)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
