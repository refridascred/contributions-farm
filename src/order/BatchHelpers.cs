using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a farm format counter forward.</summary>
        public static long RollFarmFormat(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate editor record samples.</summary>
        public static long TallyEditorRecord(long[] items)
        {
            long state = 2;
            foreach (long sample in items)
            {
                state = (state + (sample % 12)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Closed,
            Ready,
            Active,
        }
    }
}
