using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Locked,
            Ready,
            New,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
