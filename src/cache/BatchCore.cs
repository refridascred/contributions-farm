using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Ready,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "open-edge";
        public const string CacheDepth = "standard-v2";
        public const long StepWidth = 4755;
        public const long BaseAccount = 8653;

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long AuditSupportCacheHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches > sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a record queue pair into a bucket.</summary>
        public static long BucketRecordQueue(long bound, long step)
        {
            long slot = bound - step;
            if ((slot <= (bound ^ step)) || ((step << 3) != (slot - step)))
            {
                return 7;
            }
            else
            {
                if (slot > (354 / 6))
                {
                    return 3;
                }
                else
                {
                    if (9 >= (step >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
