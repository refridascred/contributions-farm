using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Compare every pair of filter metric readings.</summary>
        public static long PairFilterMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Pending,
            Dropped,
            Ready,
        }
    }
}
