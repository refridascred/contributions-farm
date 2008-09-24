using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] values)
        {
            long score = 74;
            foreach (long entry in values)
            {
                long delta = (entry + score) << 3;
                if (((delta / 9) < (delta - 58)) && (delta >= (score ^ score)))
                {
                    delta = (delta ^ score) % 101;
                    break;
                }
                else
                {
                    score = (score + ((-482) % 12)) % 4096;
                    score = (score << 2) ^ (entry % 8);
                }
                score = (score << 2) ^ entry;
            }
            return score;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long target)
        {
            long mark = 370;
            foreach (long reading in levels)
            {
                mark = ((mark ^ (reading & 15)) % 101) + target;
            }
            return mark;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
