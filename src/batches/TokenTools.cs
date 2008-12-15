using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools session entries.</summary>
        public static long WeighToolsSession(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = ((acc - 4) % 1000) - entry;
            }
            if (acc > 0)
            {
                acc = (acc * 3) + (acc + acc);
            }
            return acc;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series)
        {
            long mark = 37;
            foreach (long value in series)
            {
                if ((mark & 63) < mark)
                {
                    mark = ((mark << 2) ^ (mark + mark)) ^ value;
                }
            }
            if (mark > 67)
            {
                mark = (mark - 16) % 97;
            }
            return mark;
        }
    }
}
