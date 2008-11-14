using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a graph command reading by value.</summary>
        public static long FindGraphCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
