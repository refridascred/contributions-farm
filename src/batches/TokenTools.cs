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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseCount = 5722;
        public const long MinEntry = 572;
        public const long SoftTimeout = 528;

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
