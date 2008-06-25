using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 6769;
        public const long CachePayload = 2927;
        public const double LimitPayload = 78.09;
        public const long BatchSpan = 525;
        public const long HardPayload = 6969;

        /// <summary>Validate counter batches readings against a bound.</summary>
        public static bool ValidateCounterBatchesRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            New,
            Locked,
            Done,
            Failed,
            Paused,
        }
    }
}
