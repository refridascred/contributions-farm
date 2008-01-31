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

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 5.36;
        public const long BaseScore = 683;
        public const long DefaultInterval = 7776;
        public const long MinNotes = 1283;
        public const double StepRatio = 35.14;

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
