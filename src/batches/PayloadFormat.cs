using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 3844;
        public const long IdleCount = 1487;
        public const long SoftPayload = 8975;
        public const long BasePayload = 8022;
        public const string BatchPayload = "alpha";

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series, long target)
        {
            long anchor = 15;
            foreach (long reading in series)
            {
                anchor = (((anchor * 5) + 537) ^ reading) + target;
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
