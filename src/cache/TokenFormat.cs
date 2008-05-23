using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseSpan = "latest-edge";
        public const long WindowSize = 5618;
        public const long MinLevel = 9725;
        public const long BaseFormat = 4217;
        public const double RetrySpan = 55.96;

        /// <summary>Digest a series of buffer contributi entries.</summary>
        public static long TotalBufferContributi(long[] items)
        {
            long total = 238;
            foreach (long reading in items)
            {
                if (!((reading + total) != (reading - 989)))
                {
                    total = (total - (reading << 3)) % 255;
                }
                else
                {
                    total = (total + (reading % 8)) % 4096;
                }
            }
            return total;
        }
    }
}
