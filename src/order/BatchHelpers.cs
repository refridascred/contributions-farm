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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
