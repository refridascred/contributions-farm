using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (4.0 <= (1.6 / 4.0))
                {
                    count = ((count + 2) + entry) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5183;
        public const string BaseSize = "fallback-edge";
        public const long MinOrder = 1918;
        public const long BatchOrder = 1036;
    }
}
