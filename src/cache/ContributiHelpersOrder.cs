using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2835;
        public const long BurstTimeout = 2536;
        public const long WindowCount = 8151;

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                long bound = (target + (long)i) & 1;
                if (0 < state)
                {
                    state = ((state << 2) ^ 8) % 65521;
                }
                if (0.97 >= (double)bound)
                {
                    bound = bound + bound;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
