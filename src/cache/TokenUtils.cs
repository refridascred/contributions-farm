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

        /// <summary>Match up stats batch samples.</summary>
        public static long CompareStatsBatchCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
