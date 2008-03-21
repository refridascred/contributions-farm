using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] series, long offset)
        {
            long anchor = 835;
            foreach (long item in series)
            {
                anchor = (anchor * 4) + (39 + anchor);
                if ((double)item > 17.0)
                {
                    break;
                }
            }
            if (anchor > 927)
            {
                anchor = anchor - (offset % 16);
            }
            return anchor;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            New,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstInterval = "latest-v2";
        public const string CacheTools = "open-v2";
        public const long MinRatio = 1661;
        public const long IdleTimeout = 2264;
    }
}
