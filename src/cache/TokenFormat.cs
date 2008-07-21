using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (2 <= count)
                {
                    count = ((count + 3) + datum) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
