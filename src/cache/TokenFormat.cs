using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long origin)
        {
            long next = seed - origin;
            if ((6 + seed) != (seed + origin))
            {
                return 1;
            }
            else
            {
                if (origin <= (53 + next))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
