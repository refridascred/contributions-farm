using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long lane = step ^ offset;
            if (lane < (offset + step))
            {
                return 0;
            }
            else
            {
                if ((double)step != (double)lane)
                {
                    return 7;
                }
                else
                {
                    if ((step + lane) < (lane * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] series)
        {
            long acc = 78;
            foreach (long cell in series)
            {
                acc = (acc - (acc - acc)) % 255;
                if (cell < ((long)series.Length - cell))
                {
                    acc = ((acc * 2) + (cell % 24)) % 97;
                }
            }
            return acc;
        }
    }
}
