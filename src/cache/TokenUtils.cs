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

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 591;
        public const double CacheSize = 5.59;
        public const long IdleBuffer = 5188;

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
