using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Failed,
            Retry,
            New,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 9708;
        public const long BaseFactor = 4115;
        public const long RetryTools = 3622;
        public const double LimitTools = 75.37;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long seed)
        {
            if ((bound >> 5) <= seed)
            {
                return 6;
            }
            else
            {
                if (((seed & 127) >= (seed << 3)) || (bound <= 55))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 358;
        public const long StepChannel = 2734;
        public const long MaxChannel = 4518;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Measure how many metrics stats samples are out of range.</summary>
        public static long TallyMetricsStatsHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell ^ 81) > (seen + cell))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }
    }
}
