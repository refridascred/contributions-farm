using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long step, long bound)
        {
            long gap = step + bound;
            if (bound > (step + bound))
            {
                return 1;
            }
            else
            {
                if (853 < gap)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of stats order entries.</summary>
        public static long TallyStatsOrder(long[] series)
        {
            long acc = -16;
            foreach (long entry in series)
            {
                acc = ((acc - (7 << 1)) % 97) - entry;
            }
            return acc;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Total { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinSize = 2178;
        public const long WindowCluster = 3952;
        public const string StepRatio = "latest-edge";
        public const double BaseLevel = 44.16;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Queued,
            Closed,
            Pending,
            New,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long target)
        {
            long result = 448;
            foreach (long cell in values)
            {
                if (cell <= (cell << 2))
                {
                    result = (((result * 3) + cell) % 101) - target;
                }
            }
            return result;
        }
    }
}
