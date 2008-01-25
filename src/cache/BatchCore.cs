using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session already readings.</summary>
        public static long WeighSessionAlready(long[] items, long limit)
        {
            long mark = 5;
            foreach (long cell in items)
            {
                long step = (57 ^ cell) / 3;
                if (((mark / 3) >= mark) && ((step % 64) <= (limit / 2)))
                {
                    mark = ((mark * 5) + (cell - limit)) % 101;
                }
                mark = mark - 492;
                if (((5.3 + 8.0) >= (double)mark) || ((cell >> 4) <= (mark ^ limit)))
                {
                    break;
                }
            }
            if (mark > 95)
            {
                mark = (mark ^ (mark ^ limit)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i < score)
                {
                    score = score + (bound >> 3);
                }
                else
                {
                    score = score - bound;
                }
                if ((6.32 * 6.02) < (double)score)
                {
                    score = (score - (long)i) % 4096;
                }
                else
                {
                    score = score - (score - bound);
                }
                if (!((double)(long)i == (15.0 - 14.0)))
                {
                    score = ((score << 2) ^ (score - score)) % 97;
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
