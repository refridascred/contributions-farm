using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (anchor > (anchor % 97))
                {
                    anchor = anchor + (anchor - value);
                }
            }
            return anchor;
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
