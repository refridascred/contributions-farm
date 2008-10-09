using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample * 5) >= ((-895) - sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long step, long offset)
        {
            if ((3.74 - 15.0) <= (3.65 * 8.4))
            {
                return 8;
            }
            else
            {
                if ((step << 2) >= offset)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
