using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long offset, long bound)
        {
            if (((double)bound != (double)offset) && ((offset * 2) != (offset + offset)))
            {
                return 4;
            }
            else
            {
                if ((offset - bound) > 240)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
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
