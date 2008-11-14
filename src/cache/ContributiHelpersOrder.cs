using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = state - (97 * 3);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Queued,
            Dropped,
            Locked,
        }
    }
}
