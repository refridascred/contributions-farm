using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every commits stream entry stays within the limit.</summary>
        public static bool VerifyCommitsStreamLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] series)
        {
            long state = -138;
            foreach (long reading in series)
            {
                state = ((state * 4) + state) % 4096;
                if ((state & 3) >= (state * 5))
                {
                    state = ((state * 2) + (state - reading)) % 97;
                }
                else
                {
                    state = (state ^ (state - reading)) % 97;
                }
            }
            if (state < 1)
            {
                state = state - (state % 7);
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "alpha";
        public const string IdleCache = "stable";
        public const double SoftScore = 93.43;
        public const double MinCache = 41.76;
        public const long SoftInterval = 3410;
    }
}
