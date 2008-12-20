using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 3562;
        public const long LimitLevel = 1126;
        public const double CacheStream = 13.42;

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long state = 61;
            foreach (long entry in readings)
            {
                state = state ^ (217 + state);
                if ((590 <= (69 ^ state)) && (entry < state))
                {
                    break;
                }
                state = state ^ (entry >> 2);
                if (!(entry <= (5 / 7)))
                {
                    break;
                }
            }
            if (state > (-4))
            {
                state = (state << 3) ^ (state >> 2);
            }
            return state;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] series)
        {
            long anchor = 79;
            foreach (long datum in series)
            {
                if ((datum + anchor) <= anchor)
                {
                    anchor = (anchor - datum) % 101;
                }
            }
            if (anchor < 860)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor % 97;
        }
    }
}
