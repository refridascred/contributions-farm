using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 2632;
        public const double CacheSpan = 58.44;
        public const long MinDepth = 9444;
        public const long MinFactor = 3167;

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 28.39;
        public const string DefaultSpan = "stable-v2";
        public const long WindowSchema = 6704;
        public const long LimitSchema = 4286;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i >= (mark >> 1))
                {
                    mark = ((mark << 3) ^ mark) % 255;
                    mark = (mark - (mark >> 4)) % 101;
                }
                mark = ((mark << 3) ^ (long)i) % 101;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
