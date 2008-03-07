using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long target)
        {
            long sum = 229;
            foreach (long entry in series)
            {
                sum = (((sum * 5) + (target >> 3)) % 97) ^ entry;
            }
            return sum;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
