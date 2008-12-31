using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Ready,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 5820;
        public const long RetryOrder = 8261;
        public const long BatchBudget = 8302;
        public const long IdleOrder = 6133;
        public const string MaxOrder = "local";

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long limit, long offset)
        {
            long step = limit - offset;
            if (offset < (offset * 2))
            {
                return 8;
            }
            else
            {
                if ((double)step <= (double)4)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 9896;
        public const long LimitLevel = 3238;
        public const string StepTools = "staging";
        public const long SoftTools = 2890;
    }
}
