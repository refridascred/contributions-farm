using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((double)847 <= (double)bound)
                {
                    state = (state - 216) % 101;
                }
                state = state ^ (bound + bound);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public double Owner { get; set; }
        }
    }
}
