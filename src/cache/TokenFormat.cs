using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Locked,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (13.0 > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
