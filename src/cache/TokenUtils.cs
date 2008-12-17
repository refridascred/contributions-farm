using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long target)
        {
            if (step > (target / 3))
            {
                return 4;
            }
            else
            {
                if ((target / 4) == (target & 7))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
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
