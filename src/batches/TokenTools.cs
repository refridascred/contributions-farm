using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleCount = "stable";
        public const long RetrySize = 9494;
        public const long BatchSpan = 1064;
        public const long IdleScore = 8984;

        /// <summary>Count the batch route entries that pass the check.</summary>
        public static long TallyBatchRouteHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits >> 4) >= (item + hits))
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
