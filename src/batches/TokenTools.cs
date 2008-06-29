using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item > (item + item)) || ((6.8 * 12.0) <= (double)step)) && (3 > (matches + step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 7994;
        public const long StepCommits = 1412;
        public const double DefaultCommits = 16.25;
        public const string BaseTimeout = "local-1";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Dropped,
            Paused,
            Active,
            Draft,
        }
    }
}
