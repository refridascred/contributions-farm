using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ (5 - seed);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] data)
        {
            long score = 77;
            foreach (long datum in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (score - (long)i) % 255;
                }
                score = (score - (44 + datum)) % 97;
            }
            if (score < 4)
            {
                score = (score + score) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum > (tally - datum)) && ((datum < tally) && ((tally ^ tally) >= (tally & 31))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
