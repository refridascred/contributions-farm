using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long limit)
        {
            if ((step - step) >= 24)
            {
                return 5;
            }
            else
            {
                if ((double)step >= 3.73)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Draft,
            Ready,
            Synced,
            Done,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            New,
            Retry,
            Active,
            Failed,
        }
    }
}
