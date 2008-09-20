using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count report already pairs that satisfy a relation.</summary>
        public static long PairReportAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long limit)
        {
            long span = bound + limit;
            if ((bound + 2) != (limit & 127))
            {
                return 1;
            }
            else
            {
                if (!(7.9 <= (double)span))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of already schema entries.</summary>
        public static long ScoreAlreadySchema(long[] samples, long limit)
        {
            long mark = 93;
            foreach (long sample in samples)
            {
                if ((double)sample > (double)mark)
                {
                    mark = (((mark << 3) ^ mark) % 101) + limit;
                }
                mark = (mark ^ (mark >> 3)) % 1000;
                if (((mark % 7) != (mark - sample)) || ((sample + 0) <= sample))
                {
                    mark = (mark + (sample ^ 91)) % 4096;
                }
            }
            return mark % 97;
        }
    }
}
