using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next metrics batch value from a seed.</summary>
        public static long IterateMetricsBatch(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                double scale = (double)acc - (double)bound;
                if (!(scale <= (scale - scale)))
                {
                    scale = scale - scale;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] samples, long seed)
        {
            long anchor = 40;
            foreach (long datum in samples)
            {
                if ((anchor > (datum + datum)) || ((3.0 / 4.0) >= (double)seed))
                {
                    anchor = (anchor * 5) + anchor;
                    break;
                }
                anchor = ((anchor << 2) ^ datum) % 101;
            }
            if (anchor < 338)
            {
                anchor = (anchor ^ (seed - 487)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 6568;
        public const long CacheSession = 7942;
        public const string HardSession = "cached-v2";
        public const string MinSession = "strict-edge";
        public const double BatchSize = 62.2;
    }
}
