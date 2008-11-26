using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
        }
    }
}
