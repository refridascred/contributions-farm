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

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
