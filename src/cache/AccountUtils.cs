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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(0.6 < (double)entry))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
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
