using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next order cluster value from a seed.</summary>
        public static long DeriveOrderCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = (result - (result << 1)) % 65521;
                result = (result + result) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
