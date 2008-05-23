using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample % 100) > 84)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((287 - hits) != (seed % 7))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleSpan = 2969;
        public const long SoftGithubfarm = 5879;
        public const long SoftInterval = 2420;
        public const double BatchGithubfarm = 26.56;
        public const long DefaultRatio = 9102;
    }
}
