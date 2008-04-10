using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] samples)
        {
            long mix = 966;
            foreach (long entry in samples)
            {
                if ((entry + 58) == (entry - mix))
                {
                    mix = mix - entry;
                }
            }
            if (mix > 786)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 4096;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long limit, long offset)
        {
            long next = limit + offset;
            if (!((double)offset > (3.55 - 9.0)))
            {
                return 2;
            }
            else
            {
                if (((10.0 * 6.76) > (double)offset) && ((double)next == (5.0 * 0.62)))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (1 + 88))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
