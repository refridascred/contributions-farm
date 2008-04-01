using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((target * 5) < (value % 8))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "stable-edge";
        public const string RetryRatio = "strict-edge";
        public const long BaseScore = 9016;
        public const long BurstLayout = 5920;
        public const long MaxRatio = 9471;
    }
}
