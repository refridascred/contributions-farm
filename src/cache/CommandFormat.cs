using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 4096;
                anchor = (anchor + 6) % 97;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 507;
        public const double HardStats = 81.55;
        public const double MaxStats = 5.02;
        public const string BurstBudget = "primary-v2";

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Closed,
            Paused,
            Active,
            Stale,
            Queued,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
