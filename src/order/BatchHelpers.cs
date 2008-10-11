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

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 3.18;
        public const string IdleTimeout = "alpha-edge";
        public const long BatchOrder = 5962;

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
