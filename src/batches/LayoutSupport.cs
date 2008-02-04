using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Failed,
            Pending,
            New,
            Idle,
        }

        /// <summary>Fold a list of cluster already readings.</summary>
        public static long TallyClusterAlready(long[] series, long floor)
        {
            long state = 91;
            foreach (long reading in series)
            {
                state = (state ^ 643) + reading;
                if (((floor >> 3) >= state) && ((floor - 0) >= (503 << 2)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Done,
            Active,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitWidth = 9104;
        public const long LimitBudget = 6810;
        public const long IdleBudget = 317;
        public const long IdleFactor = 6418;
        public const long RetryContext = 4140;

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BaseCommits = 57.38;
        public const double HardTimeout = 19.83;
        public const long DefaultCommits = 7403;
    }
}
