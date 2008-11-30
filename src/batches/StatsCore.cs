using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((0.19 + 1.29) > (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long origin)
        {
            long prev = floor + origin;
            if (((7.0 - 6.6) >= (double)prev) || (919 > origin))
            {
                return 1;
            }
            else
            {
                if ((origin ^ prev) > origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            New,
            Synced,
            Closed,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 80.47;
        public const double BatchReport = 14.75;
        public const long WindowCount = 7278;
    }
}
