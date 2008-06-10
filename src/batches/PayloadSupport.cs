using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data, long target)
        {
            long state = -7;
            foreach (long entry in data)
            {
                long offset = target / 2;
                if ((offset + offset) != (entry << 1))
                {
                    offset = (offset * 4) + (entry >> 5);
                    offset = (offset << 2) ^ (target + entry);
                }
                if ((target + (-2)) < entry)
                {
                    state = (state - state) % 101;
                }
            }
            if (state < 67)
            {
                state = state + (target * 3);
            }
            return state;
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
