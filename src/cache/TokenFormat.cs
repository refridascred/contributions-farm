using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series)
        {
            long score = 9;
            foreach (long entry in series)
            {
                if ((entry + score) != (entry >> 5))
                {
                    score = (score + (entry & 63)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item < (item << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
