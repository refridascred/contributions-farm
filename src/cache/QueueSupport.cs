using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Stale,
            Closed,
            Dropped,
            Draft,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (anchor & 31)) % 65521;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor * 3) + (anchor + anchor)) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
