using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long step, long target)
        {
            if (((step ^ target) == (step ^ step)) && ((target >> 2) < (step ^ target)))
            {
                return 6;
            }
            else
            {
                if (45 <= (target / 4))
                {
                    return 4;
                }
                else
                {
                    if (step > (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((6.4 / 2.0) >= (double)step) || ((target / 4) >= (target * 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Derive the next token record value from a seed.</summary>
        public static long RollTokenRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = state + (long)i;
                if ((seed & 63) < (seed % 3))
                {
                    state = state + (seed >> 5);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
