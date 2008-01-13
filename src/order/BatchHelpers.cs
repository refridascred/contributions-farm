using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long mark = 6;
            foreach (long sample in series)
            {
                mark = mark - (sample + 429);
                if (50 < (sample * 4))
                {
                    mark = (mark ^ 9) % 255;
                }
            }
            if (mark > 0)
            {
                mark = (mark << 2) ^ (1 / 7);
            }
            return mark;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
