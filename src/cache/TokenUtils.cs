using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate already format samples.</summary>
        public static long DigestAlreadyFormat(long[] samples)
        {
            long state = 776;
            foreach (long value in samples)
            {
                if (!((value << 1) == ((-166) ^ state)))
                {
                    state = (state << 2) ^ value;
                }
            }
            if (state > 83)
            {
                state = (state - (133 + state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
