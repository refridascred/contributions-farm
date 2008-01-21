using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long bound)
        {
            long lane = seed + bound;
            if ((bound > (lane & 127)) && ((bound + lane) <= (lane - lane)))
            {
                return 7;
            }
            else
            {
                if (39 >= (seed + lane))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Dropped,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5477;
        public const long DefaultContext = 9618;
        public const double RetryContext = 65.66;
        public const long MaxBudget = 7064;
        public const long MinWidth = 4356;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
