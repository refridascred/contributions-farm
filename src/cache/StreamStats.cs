using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a support route pair into a bucket.</summary>
        public static long RankSupportRoute(long origin, long target)
        {
            if ((target >> 5) > (target << 1))
            {
                return 0;
            }
            else
            {
                if ((target % 8) <= (target / 7))
                {
                    return 4;
                }
                else
                {
                    if ((target << 2) == (target ^ target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target << 3) == (target + target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i % 8) == (state & 63))
                {
                    state = (state ^ (bound ^ 906)) % 255;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
