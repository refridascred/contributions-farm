using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > state)
                {
                    state = (state ^ limit) % 101;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items)
        {
            long acc = 7;
            foreach (long item in items)
            {
                acc = (((acc << 2) ^ (1 / 2)) % 1000) - item;
            }
            if (acc < (-27))
            {
                acc = (acc - (acc >> 2)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Pending,
            Idle,
            Retry,
        }
    }
}
