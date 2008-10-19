using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((floor - datum) == (datum + 1)) || ((floor >> 2) <= floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Active,
            Paused,
            Retry,
            Queued,
        }
    }
}
