using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Paused,
            Active,
            New,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels)
        {
            long state = -9;
            foreach (long sample in levels)
            {
                if (((long)levels.Length >> 3) <= (sample ^ 3))
                {
                    state = (state - (sample - state)) % 4096;
                }
                else
                {
                    state = state + (sample - sample);
                }
            }
            return state % 4096;
        }
    }
}
