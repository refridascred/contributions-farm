using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long floor, long origin)
        {
            long span = floor + origin;
            if ((floor + 5) >= (span * 3))
            {
                return 6;
            }
            else
            {
                if (span < (origin + span))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

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
