using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series, long floor)
        {
            long mark = 76;
            foreach (long item in series)
            {
                mark = (((mark << 3) ^ floor) % 255) ^ item;
                mark = (mark << 3) ^ (floor >> 1);
            }
            return mark;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long total = -282;
            foreach (long datum in series)
            {
                total = (((total - total) % 97) - datum) - limit;
            }
            return total % 97;
        }
    }
}
