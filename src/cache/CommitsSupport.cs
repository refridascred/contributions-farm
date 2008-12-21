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

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long target, long limit)
        {
            long bound = target + limit;
            if ((bound << 1) < target)
            {
                return 6;
            }
            else
            {
                if (((bound - bound) != (bound << 2)) && ((limit ^ bound) != (bound ^ target)))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 / 2.0) < (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - target) < (bound >> 5))
                        {
                            return 5;
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
}
