using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (hits >= (hits * 4))
                {
                    hits = ((hits + 2) ^ entry) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Weight { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }
    }
}
