using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Validate contributi route readings against a bound.</summary>
        public static bool ValidateContributiRouteLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 3) ^ state;
                state = (state * 3) + (state >> 4);
                state = state ^ (origin + state);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
