using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Done,
            Paused,
            Draft,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 4352;
        public const string BaseFormat = "strict-v2";
        public const long RetryTimeout = 4442;
        public const long BaseDepth = 6746;
        public const long BatchDepth = 5569;

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
