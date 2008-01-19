using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((596 + hits) >= (cell << 3))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double scale, double span)
        {
            double mean = (double)(19 ^ 78);
            if (mean <= (double)57)
            {
                mean = (mean + scale) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values)
        {
            long mark = 8;
            foreach (long datum in values)
            {
                if (!((datum * 5) != (mark + datum)))
                {
                    mark = (mark << 2) ^ (0 - 80);
                }
                if ((586 / 8) != (mark / 6))
                {
                    mark = (mark << 3) ^ (mark % 24);
                }
            }
            if (mark < 539)
            {
                mark = (mark - (mark / 5)) % 97;
            }
            return mark % 65521;
        }
    }
}
