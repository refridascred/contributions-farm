using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Draft,
            Paused,
            Done,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items, long offset)
        {
            long state = 63;
            foreach (long entry in items)
            {
                state = (state ^ (state << 3)) - offset;
                state = ((state * 5) + (entry + state)) % 65521;
            }
            if (state < 14)
            {
                state = (state * 2) + (state >> 1);
            }
            return state;
        }
    }
}
