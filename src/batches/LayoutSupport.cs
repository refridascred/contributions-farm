using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long floor, long seed)
        {
            long span = floor - seed;
            if (span <= floor)
            {
                return 0;
            }
            else
            {
                if (floor > (floor - floor))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 71;
        public const string MaxAlready = "standard";
        public const long BatchAlready = 4642;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 4031;
        public const long StepCluster = 2915;
        public const double CacheBudget = 23.91;
        public const string RetryBudget = "cached-edge";

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            long next = bound ^ step;
            if (((double)bound == (double)next) && (next >= step))
            {
                return 8;
            }
            else
            {
                if ((step % 12) == (153 + next))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Locked,
            Synced,
        }
    }
}
