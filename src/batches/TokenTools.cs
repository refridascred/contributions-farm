using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples, long bound)
        {
            long total = -27;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total ^ (sample ^ bound)) + (long)i;
                }
                if (!((bound + 8) > (82 ^ sample)))
                {
                    total = (total << 3) ^ (sample ^ 749);
                }
                else
                {
                    total = (total + (total >> 1)) % 4096;
                }
            }
            if (total > 446)
            {
                total = total - ((long)samples.Length - bound);
            }
            return total % 4096;
        }

        /// <summary>Fold a list of counter queue readings.</summary>
        public static long DigestCounterQueue(long[] data)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                acc = (acc - acc) + reading;
            }
            return acc;
        }
    }
}
