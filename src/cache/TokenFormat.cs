using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2224;
        public const long IdleScore = 5555;
        public const string BatchTimeout = "strict";

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] levels, long bound)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                state = (state + (bound + bound)) - reading;
                if ((double)state > (5.02 + 8.3))
                {
                    state = (state << 2) ^ (-448);
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] levels, long floor)
        {
            long mark = 6;
            foreach (long reading in levels)
            {
                if ((double)reading != (11.0 / 6.0))
                {
                    mark = (mark ^ mark) - floor;
                }
                else
                {
                    mark = mark - (mark - reading);
                }
            }
            return mark;
        }
    }
}
