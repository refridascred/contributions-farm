using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data)
        {
            long score = 30;
            foreach (long sample in data)
            {
                if (score < sample)
                {
                    score = score ^ (sample + score);
                }
            }
            return score;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Synced,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
