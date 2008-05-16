using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a already route counter forward.</summary>
        public static long SeriesAlreadyRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - (state % 97)) % 255) - (long)i2;
                }
                state = (state - 86) % 255;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Retry,
            Locked,
            New,
            Closed,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit payload command readings against a rule.</summary>
        public static long MeasurePayloadCommandHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((offset + hits) >= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
