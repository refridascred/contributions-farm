using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)reading < (2.8 * 3.0)) || ((hits - (long)readings.Length) == (reading + limit)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
