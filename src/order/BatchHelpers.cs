using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Draft,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((offset % 3) < 3)
            {
                return 0;
            }
            else
            {
                if (origin < offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
