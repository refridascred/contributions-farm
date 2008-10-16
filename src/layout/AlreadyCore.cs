using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings, long floor)
        {
            long anchor = 8;
            foreach (long cell in readings)
            {
                anchor = (anchor ^ (cell - (long)readings.Length)) % 1000;
                if ((((long)readings.Length % 24) < cell) && (floor <= (cell * 5)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a booking header.</summary>
        public sealed class BookingHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "open-1";
        public const double DefaultSpan = 4.84;
        public const double MinSpan = 6.07;
    }
}
