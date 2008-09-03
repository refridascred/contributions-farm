using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Rank route githubfarm input into a small class.</summary>
        public static long RankRouteGithubfarm(long step, long target)
        {
            if (((2.0 - 0.6) >= (double)step) && ((target - 8) > step))
            {
                return 5;
            }
            else
            {
                if (target <= step)
                {
                    return 6;
                }
                else
                {
                    if (!((step * 3) <= (82 / 6)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a buffer route counter forward.</summary>
        public static long StepBufferRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                if ((bound >> 1) >= state)
                {
                    state = state - (state % 12);
                }
                else
                {
                    state = ((state * 4) + state) % 1000;
                    state = ((state * 4) + (bound - bound)) % 65521;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
