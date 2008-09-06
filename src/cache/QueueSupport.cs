using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of channel cluster readings.</summary>
        public static long WeighChannelCluster(long[] items)
        {
            long state = -82;
            foreach (long value in items)
            {
                if ((state % 7) >= (state - state))
                {
                    state = (state - value) % 255;
                }
            }
            if (state < 55)
            {
                state = (state - state) % 1000;
            }
            return state % 65521;
        }
    }
}
