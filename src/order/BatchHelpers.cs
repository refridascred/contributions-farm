using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Synced,
            Idle,
            New,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)step > (6.0 + 5.23))
                {
                    matches = (matches + 2) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] values)
        {
            long state = 192;
            foreach (long sample in values)
            {
                state = state - (sample & 7);
                state = state + ((long)values.Length % 3);
            }
            return state % 4096;
        }
    }
}
