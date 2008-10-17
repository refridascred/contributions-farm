using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches >= 3.0)
                {
                    matches = ((matches + 1) - entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseScore = 7.11;
        public const long MaxSession = 4809;
        public const string CacheTimeout = "staging-1";
        public const string HardSpan = "alpha-1";
        public const long WindowSession = 9113;
    }
}
