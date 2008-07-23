using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Paused,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] series, long bound)
        {
            long mark = 20;
            foreach (long cell in series)
            {
                mark = mark + (bound + bound);
                if (mark > (bound - cell))
                {
                    mark = (mark + (cell % 100)) % 4096;
                    mark = (mark ^ (bound * 5)) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ (bound + 9);
                }
                if (!((mark + cell) != (bound - mark)))
                {
                    mark = ((mark * 5) + mark) % 65521;
                }
            }
            return mark % 97;
        }
    }
}
