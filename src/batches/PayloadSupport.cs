using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count <= (item % 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseRatio = 55.48;
        public const long LimitOrder = 9232;
        public const long DefaultOrder = 8331;
        public const string HardOrder = "fallback";
        public const long HardBudget = 3004;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Closed,
            New,
            Dropped,
        }
    }
}
