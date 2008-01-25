using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values)
        {
            long state = 222;
            foreach (long sample in values)
            {
                if ((state - (long)values.Length) >= state)
                {
                    state = ((state << 3) ^ (sample - state)) % 65521;
                }
                else
                {
                    state = (state - (state % 97)) % 101;
                }
                if ((sample - 82) < (sample + state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
