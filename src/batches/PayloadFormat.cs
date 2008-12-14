using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 5) + ((-7) - anchor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (seed & 7);
                sum = sum ^ (seed * 3);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
