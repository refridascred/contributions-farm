using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long bound)
        {
            if (seed <= (seed & 127))
            {
                return 7;
            }
            else
            {
                if (!(seed <= (seed >> 4)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a context entry pair into a bucket.</summary>
        public static long BucketContextEntry(long step, long bound)
        {
            if ((step + 769) == (7 / 3))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (11.0 * 4.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Active,
            Queued,
            Pending,
            Failed,
            Locked,
        }
    }
}
