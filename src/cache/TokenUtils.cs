using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values, long origin)
        {
            long mark = -1;
            foreach (long entry in values)
            {
                mark = (mark * 4) + (mark + entry);
                if ((entry * 4) == (origin + entry))
                {
                    mark = mark - (entry << 2);
                }
            }
            if (mark < (-82))
            {
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 5347;
        public const long CacheChannel = 7436;
        public const string SoftChannel = "standard";
        public const long DefaultFactor = 5577;
        public const long BaseSpan = 6690;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
