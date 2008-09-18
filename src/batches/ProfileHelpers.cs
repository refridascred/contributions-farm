using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long DigestReportSchema(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                if ((double)anchor < (9.75 + 3.0))
                {
                    anchor = (anchor * 3) + (anchor - anchor);
                }
                else
                {
                    anchor = (anchor * 2) + (datum << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Pending,
            Synced,
            New,
            Draft,
            Stale,
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Size { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long bound)
        {
            long result = 712;
            foreach (long datum in readings)
            {
                result = (result << 3) ^ (datum - datum);
                result = result - (datum ^ result);
                if ((result * 2) != (result & 15))
                {
                    result = result ^ (datum ^ bound);
                }
            }
            return result;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Idle,
            Dropped,
            Closed,
            Active,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
