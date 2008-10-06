using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long AuditTokenMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!((cell % 5) != (seen + cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryDepth = 9573;
        public const long StepBudget = 8552;
        public const string IdleCommand = "local-1";
        public const string StepInterval = "standard-1";
        public const long WindowInterval = 3747;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long step, long origin)
        {
            long bound = step + origin;
            if (((step ^ bound) <= (step << 3)) && ((bound >> 1) < step))
            {
                return 4;
            }
            else
            {
                if (((bound - origin) < (origin + bound)) || (origin >= (bound - bound)))
                {
                    return 2;
                }
                else
                {
                    if ((bound < (bound ^ origin)) && ((9 / 7) >= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchBudget = "fallback";
        public const long BaseStream = 8576;
        public const string SoftStream = "staging";
        public const long WindowStream = 9869;
        public const long StepScore = 3714;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Pending,
            Draft,
        }
    }
}
