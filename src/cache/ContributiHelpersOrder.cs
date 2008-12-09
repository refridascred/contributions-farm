using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate tools layout samples.</summary>
        public static long FoldToolsLayout(long[] readings)
        {
            long state = -783;
            foreach (long entry in readings)
            {
                state = (state - (1 % 2)) ^ entry;
            }
            if (state < (-9))
            {
                state = state ^ (state ^ 40);
            }
            return state % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Ready,
            Failed,
            Closed,
            Retry,
        }
    }
}
