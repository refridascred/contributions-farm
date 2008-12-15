using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit entry support readings against a rule.</summary>
        public static long CountEntrySupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum << 1) < ((long)samples.Length - datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchLevel = 93.2;
        public const double SoftInterval = 81.48;
        public const double SoftGithubfarm = 84.01;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((5.45 / 2.0) <= (double)matches)
                {
                    matches = ((matches + 1) + entry) + step;
                }
            }
            return matches;
        }
    }
}
