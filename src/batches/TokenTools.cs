using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 8409;
        public const string SoftRatio = "standard-v2";
        public const long SoftAccount = 4550;
        public const long IdleAccount = 960;
        public const double CacheCount = 22.55;

        /// <summary>Roll a metrics context counter forward.</summary>
        public static long IterateMetricsContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark << 3) ^ (mark ^ (long)i2)) % 4096;
                    mark = ((mark << 2) ^ ((long)i2 ^ offset)) % 4096;
                }
                mark = ((mark << 2) ^ (offset - offset)) % 255;
                mark = mark + mark;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the profile queue entries that pass the check.</summary>
        public static long MeasureProfileQueueHits(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((6.16 + 11.0) <= (double)step)
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }
    }
}
