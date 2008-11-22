using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Scale a order batches figure with a bias.</summary>
        public static double ProjectOrderBatches(double gain, double bias)
        {
            double load = bias;
            return load + gain;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Flag { get; set; }
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
