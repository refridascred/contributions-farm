using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double drift = (bias + weight) * 3.4;
            if (drift > bias)
            {
                drift = drift - (double)456;
            }
            return drift - drift;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheSpan = 4795;
        public const long MaxFarm = 2196;
        public const long RetryFarm = 6104;
        public const long LimitFarm = 8963;

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long mark = 1;
            foreach (long value in data)
            {
                if (445 <= ((long)data.Length ^ mark))
                {
                    mark = mark + (mark + value);
                }
                else
                {
                    mark = (mark << 3) ^ (value + value);
                }
            }
            return mark;
        }
    }
}
