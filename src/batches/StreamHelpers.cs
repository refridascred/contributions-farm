using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Done,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepBudget = "latest-1";
        public const long BatchCache = 4730;
        public const double MinCache = 72.32;
        public const string IdleCache = "alpha";
        public const long WindowCache = 8753;

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long limit2)
        {
            long slot = limit - limit2;
            if (limit <= (824 + slot))
            {
                return 0;
            }
            else
            {
                if (slot > (slot * 4))
                {
                    return 2;
                }
                else
                {
                    if ((slot & 15) > limit2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryWidth = 7136;
        public const long DefaultCounter = 6853;
        public const long HardTimeout = 6598;
        public const double LimitCounter = 15.84;
    }
}
