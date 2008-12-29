using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 34.22;
        public const double RetryGithubfarm = 39.76;
        public const string BaseSpan = "strict-v2";
        public const long DefaultDepth = 1028;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit checks entry readings against a rule.</summary>
        public static long CountChecksEntryHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((tally / 2) < datum) || (datum <= (datum - datum))) || ((double)tally < 17.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
