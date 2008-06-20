using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 6249;
        public const long RetryEditor = 7384;
        public const double CacheRatio = 53.65;

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long floor)
        {
            if ((9.0 / 7.0) >= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((double)offset > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (offset < (-733))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Ready,
            Queued,
            Paused,
        }
    }
}
