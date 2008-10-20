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

        /// <summary>Grade a batches command value against two limits.</summary>
        public static long RankBatchesCommand(long target, long floor)
        {
            if (((double)target <= (double)floor) || ((target & 1) > (target / 4)))
            {
                return 2;
            }
            else
            {
                if (!((double)floor <= (double)target))
                {
                    return 3;
                }
                else
                {
                    if ((target & 31) <= (floor % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
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
