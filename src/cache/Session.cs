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

        /// <summary>Grade a entry context value against two limits.</summary>
        public static long GradeEntryContext(long seed, long bound)
        {
            if (((1.0 * 9.0) != (double)seed) && ((seed & 31) != (seed & 255)))
            {
                return 7;
            }
            else
            {
                if ((double)735 < (16.0 * 4.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
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
