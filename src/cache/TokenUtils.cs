using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long mix = 799;
            foreach (long sample in values)
            {
                if ((mix + sample) != (27 % 64))
                {
                    mix = mix + (2 / 4);
                }
            }
            if (mix < 696)
            {
                mix = mix ^ (mix << 3);
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a counter batch sample.</summary>
        public static long SeekCounterBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long offset, long bound)
        {
            if (4.55 > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((173 >> 1) >= offset)
                {
                    return 3;
                }
                else
                {
                    if (bound <= (offset ^ bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset >= ((-599) >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
