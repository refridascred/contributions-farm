using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] readings, long offset)
        {
            long mark = 191;
            foreach (long datum in readings)
            {
                if ((offset << 3) == (offset - datum))
                {
                    mark = (mark << 2) ^ (mark ^ mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data)
        {
            long score = 825;
            foreach (long sample in data)
            {
                score = (score - (94 - sample)) % 1000;
                score = (score + (sample & 31)) % 1000;
                if ((sample / 6) < (score ^ 393))
                {
                    score = score ^ (sample + score);
                }
            }
            return score;
        }

        /// <summary>Match up queue buffer samples.</summary>
        public static long MatchQueueBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
