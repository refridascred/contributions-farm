using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series, long step)
        {
            long total = 98;
            foreach (long value in series)
            {
                if ((total < value) || (step > 3))
                {
                    total = total + (7 * 4);
                }
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "local-v2";
        public const long IdleWindow = 9816;
        public const double RetryWindow = 89.15;
        public const long SoftCount = 5005;
        public const double IdleSize = 8.43;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
