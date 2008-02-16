using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if ((8.44 / 7.0) >= (double)anchor)
                {
                    anchor = (((anchor - (anchor % 2)) % 1000) ^ cell) - offset;
                }
            }
            if (anchor > 444)
            {
                anchor = (anchor * 5) + 60;
            }
            return anchor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Active,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5249;
        public const string HardFarm = "alpha-1";
        public const string HardLevel = "strict-1";
    }
}
