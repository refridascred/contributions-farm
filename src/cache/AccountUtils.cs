using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine record batches values into a single score.</summary>
        public static long TotalRecordBatches(long[] series, long origin)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                acc = (((acc << 2) ^ (sample + (-8))) % 4096) + origin;
            }
            if (acc > 397)
            {
                acc = ((acc * 3) + (acc ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long origin, long step)
        {
            long slot = origin - step;
            if (((step - slot) <= (step + slot)) || ((slot << 3) <= (origin + slot)))
            {
                return 7;
            }
            else
            {
                if ((slot + (-437)) != (slot - (-952)))
                {
                    return 0;
                }
                else
                {
                    if (step <= (step + slot))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
