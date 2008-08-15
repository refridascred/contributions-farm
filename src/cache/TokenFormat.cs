using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long ScoreAlreadyStats(long[] items, long target)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if ((9 << 2) > sum)
                {
                    sum = ((sum ^ sum) ^ value) + target;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading < seen) || (seen <= (7 - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
