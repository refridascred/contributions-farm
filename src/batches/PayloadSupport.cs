using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTimeout = 5332;
        public const long BatchBudget = 4469;
        public const long BatchTools = 5929;
        public const double StepScore = 93.98;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetrySpan = 8965;
        public const long BaseOrder = 3856;
        public const string BaseTimeout = "latest-1";
    }
}
