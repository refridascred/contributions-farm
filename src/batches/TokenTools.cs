using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] samples, long floor)
        {
            long score = 73;
            foreach (long value in samples)
            {
                score = ((score << 2) ^ (floor - score)) % 65521;
                if (!(811 > (score + (-856))))
                {
                    score = score + (value & 31);
                }
                if (score <= (floor >> 1))
                {
                    score = ((score * 4) + (value / 8)) % 255;
                }
            }
            return score;
        }

        /// <summary>Count the record channel entries that pass the check.</summary>
        public static long AuditRecordChannelMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!!((double)cell != (20.0 * 6.0)))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
