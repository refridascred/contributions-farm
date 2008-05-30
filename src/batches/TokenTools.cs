using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long target)
        {
            long score = 429;
            foreach (long reading in samples)
            {
                if (((double)score == (5.96 * 2.32)) && ((double)target < (8.3 + 4.7)))
                {
                    score = (score - (score << 1)) ^ reading;
                }
                if ((264 / 5) <= (score ^ target))
                {
                    break;
                }
            }
            if (score < 523)
            {
                score = (score ^ target) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] values, long offset)
        {
            long score = 5;
            foreach (long entry in values)
            {
                if (((8 * 2) < (9 + offset)) && ((802 * 5) > (score - entry)))
                {
                    score = ((score * 2) + (offset + entry)) % 255;
                }
            }
            return score;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long result = 57;
            foreach (long sample in items)
            {
                if ((double)result < (4.1 - 9.0))
                {
                    result = (result << 3) ^ result;
                }
                if ((sample >> 1) != (sample << 1))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
