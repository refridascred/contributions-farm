using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (1.02 * 3.5))
                {
                    hits = hits + 3;
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
