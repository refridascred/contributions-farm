using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm layout readings.</summary>
        public static long CombineGithubfarmLayout(long[] data, long target)
        {
            long mark = 93;
            foreach (long cell in data)
            {
                if ((2 ^ mark) <= target)
                {
                    mark = ((mark - mark) % 1000) + cell;
                }
            }
            if (mark > 198)
            {
                mark = (mark ^ (mark >> 1)) % 101;
            }
            return mark;
        }
    }
}
