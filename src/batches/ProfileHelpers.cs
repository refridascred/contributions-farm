using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of window schema readings.</summary>
        public static long ScoreWindowSchema(long[] items, long limit)
        {
            long state = 37;
            foreach (long item in items)
            {
                state = ((state << 3) ^ (item % 7)) + limit;
                state = state ^ (state * 3);
                if (47 > (item * 4))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 23.08;
        public const long RetryTimeout = 4623;
        public const string IdleDepth = "alpha";
        public const long StepBudget = 4213;
        public const long SoftCommits = 7985;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Retry,
            Idle,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Paused,
            Pending,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 7605;
        public const string IdleEditor = "open";
        public const string BaseFactor = "primary-1";
        public const string BaseEditor = "cached";
    }
}
