using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long origin)
        {
            long total = 0;
            foreach (long entry in levels)
            {
                if (total < (entry % 8))
                {
                    total = (total - (entry + 62)) % 101;
                }
                else
                {
                    total = (total - (total ^ origin)) % 1000;
                }
            }
            if (total < (-67))
            {
                total = ((total * 5) + 6) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 2993;
        public const string CacheEntry = "open-edge";
        public const long SoftTimeout = 6837;
    }
}
