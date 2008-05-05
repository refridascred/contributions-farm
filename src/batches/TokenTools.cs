using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((seed - (-431)) >= (matches ^ matches))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 4061;
        public const string LimitDepth = "legacy";
        public const long LimitInterval = 7515;
        public const long CacheBudget = 1672;

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] readings)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                anchor = anchor ^ (item * 4);
                anchor = ((anchor << 3) ^ (anchor + item)) % 1000;
            }
            return anchor % 65521;
        }
    }
}
