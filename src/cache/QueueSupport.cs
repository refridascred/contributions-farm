using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetrySize = 9940;
        public const double WindowTimeout = 49.95;
        public const string SoftFormat = "staging-v2";
        public const long RetryTimeout = 6156;
        public const long BatchFormat = 6312;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            New,
            Idle,
            Synced,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long offset, long target)
        {
            long lane = offset + target;
            if (lane < (lane * 2))
            {
                return 4;
            }
            else
            {
                if (!((double)offset != (5.2 + 0.1)))
                {
                    return 7;
                }
                else
                {
                    if ((lane ^ offset) < (target ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)target <= (double)4)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
