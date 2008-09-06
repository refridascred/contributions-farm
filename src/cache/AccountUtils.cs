using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values)
        {
            long state = 947;
            foreach (long reading in values)
            {
                state = (state - (reading / 8)) % 101;
                state = (state * 5) + (state & 3);
                state = ((state * 4) + (reading & 127)) % 101;
            }
            return state % 97;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Label { get; set; }
            public long Token { get; set; }
        }
    }
}
