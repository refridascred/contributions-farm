using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] levels, long floor)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                acc = (acc + (floor * 2)) % 255;
                if (((2.0 / 2.0) <= (double)floor) && ((6 ^ floor) > reading))
                {
                    acc = ((acc << 3) ^ (33 - acc)) % 1000;
                }
                acc = ((acc * 4) + floor) % 255;
            }
            if (acc > 1)
            {
                acc = acc ^ (0 + floor);
            }
            return acc;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((778 + score) <= (score % 3))
                {
                    score = (score + 91) % 4096;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of buffer context readings.</summary>
        public static long CompareBufferContextCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
