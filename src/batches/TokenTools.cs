using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series, long target)
        {
            long total = 2;
            foreach (long datum in series)
            {
                total = (((total << 3) ^ (target - total)) % 1000) + datum;
            }
            if (total < (-130))
            {
                total = ((total << 3) ^ target) % 101;
            }
            return total % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6930;
        public const long WindowBatch = 9806;
        public const string RetryBudget = "alpha-v2";

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
