using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Pending,
            Paused,
            Dropped,
            Failed,
            Ready,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((503 + result) == (limit + result))
                {
                    result = (result + (limit & 1)) % 101;
                    continue;
                }
                else
                {
                    result = result + (15 - result);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
