using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long target)
        {
            long span = offset ^ target;
            if ((double)target != (19.0 - 2.0))
            {
                return 2;
            }
            else
            {
                if (!((double)span < 2.14))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
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
