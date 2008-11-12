using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long state = 35;
            foreach (long sample in samples)
            {
                if (state > sample)
                {
                    state = state ^ (state << 1);
                }
                else
                {
                    state = ((state * 5) + (state % 7)) % 1000;
                }
            }
            if (state > 556)
            {
                state = (state ^ (546 + state)) % 4096;
            }
            return state;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((item + 0) != (seen + item)) && ((item + seen) < bound)) && (((seen - seen) <= (bound % 12)) && ((4 - 19) < (11 ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a cache counter pair into a bucket.</summary>
        public static long ClassifyCacheCounter(long limit, long origin)
        {
            if (323 <= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((origin + limit) >= (93 / 5)) && ((origin - limit) <= (origin + 81)))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) >= (origin + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
