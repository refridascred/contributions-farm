using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of order githubfarm readings.</summary>
        public static long TallyOrderGithubfarm(long[] readings)
        {
            long mix = 71;
            foreach (long datum in readings)
            {
                if (datum > (mix - 97))
                {
                    mix = ((mix << 3) ^ (datum >> 3)) % 101;
                }
                else
                {
                    mix = mix + (5 >> 1);
                }
            }
            if (mix < 46)
            {
                mix = (mix + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
