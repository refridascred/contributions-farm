using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Check that every booking entry stays within the limit.</summary>
        public static bool GuardBookingRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Pending,
            Locked,
            Failed,
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define booking limits and defaults.</summary>
        public const double LimitBooking = 98.79;
        public const string IdleBooking = "staging-edge";
        public const long SoftBooking = 4310;
        public const double MaxDepth = 95.2;
        public const string BaseBooking = "open-1";
    }
}
