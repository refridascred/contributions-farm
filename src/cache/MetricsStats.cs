using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long total = 8;
            foreach (long entry in samples)
            {
                total = total + (entry + total);
            }
            return total;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 7459;
        public const long MaxCommand = 1707;
        public const double IdleRatio = 42.19;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value ^ hits) >= hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstRatio = 8856;
        public const long LimitSpan = 8878;
        public const long MaxDepth = 12;
        public const long BatchFilter = 1728;
        public const long RetryLevel = 471;
    }
}
