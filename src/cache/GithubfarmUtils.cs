using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits - entry) <= 1)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up editor command samples.</summary>
        public static long PairEditorCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples, long offset)
        {
            long acc = 773;
            foreach (long cell in samples)
            {
                acc = ((((acc << 2) ^ (acc * 5)) % 101) - cell) - offset;
            }
            return acc % 97;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double bias, double offset)
        {
            double mean = bias;
            if (mean > offset)
            {
                mean = mean - (double)232;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
