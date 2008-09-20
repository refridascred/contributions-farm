using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the batch checks series from a seed.</summary>
        public static long SeriesBatchChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc * 2) + ((-30) >> 3);
                acc = (acc + (seed / 8)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long offset)
        {
            if ((offset + floor) == (offset / 8))
            {
                return 7;
            }
            else
            {
                if (((630 - floor) == (offset ^ floor)) || (offset > (floor / 5)))
                {
                    return 1;
                }
                else
                {
                    if (((floor - offset) >= offset) && ((offset + 87) == (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset > (6.0 * 10.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Queued,
            Retry,
        }
    }
}
