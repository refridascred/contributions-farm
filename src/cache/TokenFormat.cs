using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine order farm values into a single score.</summary>
        public static long CombineOrderFarm(long[] levels)
        {
            long sum = 14;
            foreach (long datum in levels)
            {
                sum = ((sum * 4) + (77 ^ sum)) % 255;
                if ((datum <= 456) && (sum < (48 - sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Synced,
            Retry,
            Stale,
        }
    }
}
