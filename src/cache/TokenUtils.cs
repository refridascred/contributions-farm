using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long RollToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - ((-72) / 3)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] readings)
        {
            long score = 275;
            foreach (long item in readings)
            {
                score = score + (item - score);
                score = (score - (score - item)) % 65521;
            }
            if (score < 302)
            {
                score = ((score * 3) + score) % 65521;
            }
            return score % 97;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long sum = 5;
            foreach (long entry in items)
            {
                sum = ((sum ^ (sum - 3)) % 4096) - origin;
                if (entry <= (entry * 5))
                {
                    break;
                }
            }
            if (sum < 86)
            {
                sum = (sum + (sum >> 5)) % 65521;
            }
            return sum % 4096;
        }
    }
}
