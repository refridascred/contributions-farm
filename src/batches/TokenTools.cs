using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Offset { get; set; }
            public double Score { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitWidth = 3557;
        public const long RetryChannel = 8080;
        public const long BatchChannel = 9930;
    }
}
