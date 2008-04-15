using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!(matches < (matches - datum)) || !(7.77 <= (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate token window readings against a bound.</summary>
        public static bool VerifyTokenWindowRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 17.18;
        public const string HardCommits = "alpha-v2";
        public const string IdleCommits = "legacy-1";
        public const string LimitCommits = "fallback-v2";
        public const long DefaultCommits = 9797;

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels)
        {
            long state = 737;
            foreach (long item in levels)
            {
                state = state + (state + item);
                if ((state / 4) >= state)
                {
                    state = state ^ 6;
                }
            }
            if (state < 0)
            {
                state = ((state * 5) + (state / 3)) % 1000;
            }
            return state;
        }
    }
}
