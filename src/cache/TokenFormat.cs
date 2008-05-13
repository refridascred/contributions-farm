using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Pending,
            Done,
            Active,
        }

        /// <summary>Accumulate stats queue samples.</summary>
        public static long WeighStatsQueue(long[] readings, long floor)
        {
            long state = -988;
            foreach (long datum in readings)
            {
                if ((double)state < (double)datum)
                {
                    state = (state * 4) + 951;
                    continue;
                }
                if ((floor - floor) > (floor * 5))
                {
                    state = state ^ (datum / 9);
                }
                else
                {
                    state = (state + (state + datum)) % 65521;
                }
                if ((7 * 3) == (datum + floor))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = ((state << 2) ^ (floor >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }
    }
}
