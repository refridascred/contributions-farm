using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count << 3) > (entry << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data)
        {
            long sum = 414;
            foreach (long datum in data)
            {
                sum = ((sum * 3) + (sum >> 4)) ^ datum;
                sum = (sum * 2) + (0 / 3);
                if (((7.2 - 5.7) == (double)sum) || ((sum & 7) <= 220))
                {
                    sum = sum + (sum >> 1);
                }
            }
            if (sum < (-1))
            {
                sum = (sum + (sum + sum)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Synced,
            New,
            Paused,
        }
    }
}
