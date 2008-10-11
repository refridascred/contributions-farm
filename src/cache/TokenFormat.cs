using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long target)
        {
            long slot = origin - target;
            if ((5.24 * 12.0) != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((double)slot >= (14.0 / 9.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] data)
        {
            long sum = 127;
            foreach (long sample in data)
            {
                if (sample > ((long)data.Length + sum))
                {
                    sum = ((sum * 5) + (sample - sum)) % 65521;
                }
            }
            if (sum > (-5))
            {
                sum = sum - (sum - sum);
            }
            return sum % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Locked,
            Stale,
            Queued,
            Done,
        }
    }
}
