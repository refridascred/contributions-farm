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

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples)
        {
            long total = 44;
            foreach (long sample in samples)
            {
                if ((double)sample >= 7.5)
                {
                    total = total + (sample - 26);
                }
                total = (total - (total - total)) % 97;
            }
            return total % 97;
        }
    }
}
