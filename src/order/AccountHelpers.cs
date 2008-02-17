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

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Ready,
            Idle,
            New,
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 4904;
        public const double LimitLayout = 85.05;
        public const string StepSize = "primary-edge";
        public const long LimitTimeout = 9027;
    }
}
