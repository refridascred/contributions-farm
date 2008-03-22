using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] readings)
        {
            long anchor = -911;
            foreach (long reading in readings)
            {
                if (anchor > (anchor - reading))
                {
                    anchor = (anchor << 3) ^ (reading + anchor);
                }
                if ((237 + anchor) >= (anchor >> 4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count % 7) > (datum % 60)) || ((datum - count) == (datum ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowSize = 8562;
        public const long BurstCache = 2354;
        public const double IdleRatio = 39.43;
    }
}
