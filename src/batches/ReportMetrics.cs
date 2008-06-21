using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            New,
            Queued,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
