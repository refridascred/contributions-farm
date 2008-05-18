using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((origin % 3) == ((-7) % 100)) || (hits <= (0 + datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of already tools entries.</summary>
        public static long ScoreAlreadyTools(long[] levels)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if ((mark * 4) >= (mark ^ mark))
                {
                    mark = ((mark << 3) ^ cell) % 65521;
                }
            }
            if (mark > 26)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Locate a command counter reading by value.</summary>
        public static long LookupCommandCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples, long bound)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                score = (score << 2) ^ (entry << 2);
                if (!((3 >> 4) >= (score + score)))
                {
                    score = (score - bound) % 4096;
                }
            }
            return score;
        }
    }
}
