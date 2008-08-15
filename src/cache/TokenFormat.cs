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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (8.83 > (double)count)
                {
                    count = ((count + 2) + entry) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
