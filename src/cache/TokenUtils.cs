using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data)
        {
            long state = 4;
            foreach (long reading in data)
            {
                if (((reading & 63) < (state & 255)) && ((306 - reading) >= state))
                {
                    state = (state * 5) + (reading ^ reading);
                }
            }
            if (state > 7)
            {
                state = (state ^ (state & 63)) % 101;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseCount = 7.62;
        public const long BatchLevel = 1805;
        public const string CacheSpan = "legacy-edge";
        public const double IdleSession = 48.62;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 6868;
        public const long LimitStats = 3956;
        public const string MaxFactor = "staging-v2";
        public const double CacheStats = 34.92;
    }
}
