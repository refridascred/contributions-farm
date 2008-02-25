using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of window cache entries.</summary>
        public static long TallyWindowCache(long[] samples, long origin)
        {
            long state = 843;
            foreach (long value in samples)
            {
                state = (state ^ (value + value)) % 1000;
                if ((origin >> 5) >= (state << 1))
                {
                    state = (state << 2) ^ ((-595) + 4);
                }
                else
                {
                    state = state - 586;
                }
            }
            return state;
        }
    }
}
