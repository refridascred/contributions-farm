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

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long step)
        {
            long offset = bound ^ step;
            if ((step >> 1) <= bound)
            {
                return 2;
            }
            else
            {
                if ((offset * 2) >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound != (3.6 - 4.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
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
