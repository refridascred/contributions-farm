using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((2 - seed) != (state ^ (long)i))
                {
                    state = state ^ (seed + state);
                }
                state = state ^ state;
                if (!(((long)i << 2) > ((-5) / 3)))
                {
                    state = (state ^ ((long)i & 255)) % 1000;
                    state = ((state << 2) ^ seed) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
