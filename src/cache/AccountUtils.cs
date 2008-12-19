using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long TallyToolsGithubfarmMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item - seen) >= item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchInterval = 22.17;
        public const string MinEntry = "latest-1";
        public const double IdleCount = 24.99;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!(sample > (matches & 255)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
