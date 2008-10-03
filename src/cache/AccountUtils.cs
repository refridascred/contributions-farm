using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] samples)
        {
            long mark = 80;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = (mark ^ mark) - (long)i;
                }
                if (((15.0 * 15.0) <= (double)datum) && ((mark % 8) == (mark - mark)))
                {
                    mark = (mark + (datum >> 3)) % 101;
                }
            }
            if (mark > (-6))
            {
                mark = ((mark << 3) ^ mark) % 255;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long offset)
        {
            long score = 786;
            foreach (long item in samples)
            {
                if (!((score / 9) < ((long)samples.Length - score)))
                {
                    score = (score + item) + offset;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
