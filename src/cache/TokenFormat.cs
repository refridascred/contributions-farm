using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double rate, double span)
        {
            double gain = (double)(459 / 9);
            if (gain > (double)(-3))
            {
                gain = gain + (span + rate);
            }
            else
            {
                gain = gain - (gain + 5.21);
            }
            return gain + gain;
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
