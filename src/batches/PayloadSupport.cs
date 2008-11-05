using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up notes filter samples.</summary>
        public static long CompareNotesFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] samples)
        {
            long state = 53;
            foreach (long item in samples)
            {
                if (!((item - 1) <= (state >> 5)))
                {
                    state = (state + (state << 2)) % 1000;
                }
                if ((state * 2) < state)
                {
                    state = (state - (state & 127)) % 97;
                }
            }
            if (state < 897)
            {
                state = (state << 3) ^ ((long)samples.Length + state);
            }
            return state;
        }
    }
}
