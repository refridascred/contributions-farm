using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the session token entries that pass the check.</summary>
        public static long CountSessionTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches ^ entry) < (91 / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftSpan = "standard-v2";
        public const long BatchLevel = 3152;
        public const string HardDepth = "open-edge";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((13.0 / 4.0) == (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
