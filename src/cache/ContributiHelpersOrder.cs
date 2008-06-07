using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long seed2)
        {
            if ((seed > (seed % 7)) || ((seed2 & 15) == (4 + seed2)))
            {
                return 1;
            }
            else
            {
                if (seed >= ((-1) - 475))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Draft,
            Active,
            Idle,
            Queued,
        }
    }
}
