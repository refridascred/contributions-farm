using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Draft,
            Synced,
            Closed,
            Locked,
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long step2)
        {
            long edge = step + step2;
            if (((step2 + 526) > edge) && (edge <= 485))
            {
                return 5;
            }
            else
            {
                if (620 <= (step2 % 7))
                {
                    return 3;
                }
                else
                {
                    if ((step2 >> 3) > 54)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
