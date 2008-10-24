using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Ready,
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Dropped,
            Closed,
            Failed,
            Draft,
        }
    }
}
