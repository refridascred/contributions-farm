using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count > 7.0)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Done,
            Locked,
            Failed,
            Idle,
        }

        /// <summary>Roll a command farm counter forward.</summary>
        public static long RollCommandFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Failed,
            Dropped,
            Draft,
            Active,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long floor)
        {
            if (floor >= (origin & 127))
            {
                return 8;
            }
            else
            {
                if (!((double)floor > (4.76 / 9.0)))
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 5) == (30 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)3 == (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
