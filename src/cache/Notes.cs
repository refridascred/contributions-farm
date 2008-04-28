using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1871;
        public const long SoftCluster = 5078;
        public const long SoftFactor = 7929;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Closed,
            Locked,
            Synced,
            Draft,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Ready,
            Failed,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long target)
        {
            if ((double)limit < (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)target <= 1.8) || ((limit / 8) <= 83))
                {
                    return 5;
                }
                else
                {
                    if ((3.0 / 6.0) > (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 3582;
        public const long StepSpan = 6432;
        public const double StepBudget = 81.98;
        public const long LimitAccount = 1076;
    }
}
