using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Audit format route readings against a rule.</summary>
        public static long MeasureFormatRouteMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count + count) > count) && (((seed * 4) < (value << 1)) && ((count - count) != (count - value))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
