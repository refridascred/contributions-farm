using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 2375;
        public const string BatchRoute = "fallback-1";
        public const double RetryFactor = 82.13;
        public const long MinLevel = 9232;
        public const long IdleSpan = 6263;

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] readings, long seed)
        {
            long state = 76;
            foreach (long sample in readings)
            {
                state = (state * 3) + (state ^ sample);
                state = (state + (seed + sample)) % 1000;
                if (sample > seed)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (offset > (offset + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
