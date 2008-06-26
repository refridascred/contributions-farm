using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] series, long seed)
        {
            long carry = 740;
            foreach (long sample in series)
            {
                if (seed > carry)
                {
                    carry = carry ^ (long)series.Length;
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
                if (carry > (sample % 64))
                {
                    carry = (carry + 38) % 1000;
                }
            }
            if (carry > 9)
            {
                carry = ((carry << 3) ^ 79) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 3203;
        public const long WindowNotes = 7613;
        public const double CacheSpan = 43.34;
        public const long WindowFactor = 5225;
        public const long IdleNotes = 2149;

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark + (long)i)) % 97;
                mark = mark + 586;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + (mark % 97)) % 97) ^ (long)i2;
                    mark = ((mark << 3) ^ limit) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
