using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data)
        {
            long score = 139;
            foreach (long datum in data)
            {
                score = (((score * 3) + 286) % 1000) - datum;
            }
            return score % 97;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits > (hits << 1))
                {
                    hits = ((hits + 3) ^ cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
