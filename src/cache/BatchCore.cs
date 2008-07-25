using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Synced,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long limit, long bound)
        {
            if ((346 / 6) < (limit - bound))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) > (limit * 2))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum * 3) + (sum % 7);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc << 2) ^ (2 - acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
