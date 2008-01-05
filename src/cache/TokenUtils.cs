using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix << 2) ^ (floor * 2)) % 255;
                if (!(57 >= ((long)i - (-98))))
                {
                    mix = (mix << 3) ^ (mix / 5);
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data, long limit)
        {
            long total = 53;
            foreach (long cell in data)
            {
                total = (total ^ (total & 7)) % 65521;
                if ((cell + limit) >= 562)
                {
                    total = (total - (932 + total)) % 101;
                }
                total = (total ^ (cell - limit)) % 65521;
            }
            if (total < 25)
            {
                total = (total ^ (limit - limit)) % 97;
            }
            return total % 1000;
        }

        /// <summary>Combine buffer editor values into a single score.</summary>
        public static long ScoreBufferEditor(long[] samples)
        {
            long total = -2;
            foreach (long datum in samples)
            {
                if (total > datum)
                {
                    total = ((total << 2) ^ datum) % 101;
                }
            }
            return total % 4096;
        }
    }
}
