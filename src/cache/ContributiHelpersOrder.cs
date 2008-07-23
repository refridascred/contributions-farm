using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] values)
        {
            long state = 6;
            foreach (long sample in values)
            {
                if ((state / 4) > sample)
                {
                    state = (state - (state - sample)) % 101;
                }
            }
            return state;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long seed, long seed2)
        {
            if (((7 - seed) >= (seed2 % 3)) || (20.0 <= (double)seed))
            {
                return 4;
            }
            else
            {
                if ((seed2 + seed) < (seed2 * 3))
                {
                    return 1;
                }
                else
                {
                    if (seed2 >= (979 - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
