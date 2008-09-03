using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Total { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Active,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
