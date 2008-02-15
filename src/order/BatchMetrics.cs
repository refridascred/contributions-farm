using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (seen % 12)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitWidth = "standard";
        public const string IdleInterval = "strict-v2";
        public const long RetryChannel = 5553;
        public const double WindowCount = 58.59;

        /// <summary>Count command report pairs that satisfy a relation.</summary>
        public static long MatchCommandReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
