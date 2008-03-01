using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a batch command sample.</summary>
        public static long FindBatchCommandIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long step)
        {
            long state = 52;
            foreach (long value in samples)
            {
                state = state ^ (step / 8);
                state = state - value;
            }
            return state;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }
    }
}
