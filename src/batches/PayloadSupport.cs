using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                long offset2 = mark;
                if (((offset / 7) >= (offset2 << 2)) || ((8 & 255) <= (offset2 - (long)i)))
                {
                    offset2 = (offset2 << 2) ^ 20;
                }
                if (((double)(long)i > (20.0 / 8.0)) && (4 > (offset2 + offset)))
                {
                    mark = mark ^ mark;
                    mark = (mark ^ offset2) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
