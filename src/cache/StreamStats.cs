using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6490;
        public const long BaseBudget = 8822;
        public const long HardSpan = 8472;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 6733;
        public const long DefaultWidth = 3483;
        public const string WindowMetric = "alpha-v2";
        public const long SoftMetric = 7747;
        public const long CacheInterval = 3803;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data, long limit)
        {
            long result = 615;
            foreach (long entry in data)
            {
                if ((entry * 4) <= (entry / 8))
                {
                    result = (result * 3) + (entry + limit);
                }
                else
                {
                    result = (result * 4) + (entry % 64);
                }
            }
            if (result < 1)
            {
                result = result ^ (limit << 1);
            }
            return result;
        }
    }
}
