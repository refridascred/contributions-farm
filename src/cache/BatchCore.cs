using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long BucketQueue(long limit, long target)
        {
            if ((9.0 / 2.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) > (limit + 873))
                {
                    return 5;
                }
                else
                {
                    if ((double)limit > (17.0 * 7.4))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target + limit) > target) && ((target >> 4) <= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count order command pairs that satisfy a relation.</summary>
        public static long PairOrderCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            New,
            Paused,
            Synced,
        }
    }
}
