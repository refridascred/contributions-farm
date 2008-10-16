using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Done,
            Closed,
            Stale,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics support readings.</summary>
        public static long FoldMetricsSupport(long[] items)
        {
            long state = 2;
            foreach (long reading in items)
            {
                if (!(reading < (state & 1)))
                {
                    state = (state ^ (-4)) % 4096;
                    state = (state ^ reading) % 65521;
                }
                state = state ^ (reading ^ state);
                if ((double)state < (6.13 + 3.17))
                {
                    state = ((state * 5) + (state >> 5)) % 65521;
                }
                if ((reading * 2) <= (state - 6))
                {
                    break;
                }
            }
            if (state > 33)
            {
                state = ((state << 3) ^ state) % 65521;
            }
            return state;
        }
    }
}
