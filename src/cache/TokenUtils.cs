using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                if (!((78 * 4) < (limit + limit)))
                {
                    total = (total + limit) % 65521;
                    total = ((total << 3) ^ (limit / 5)) % 65521;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
