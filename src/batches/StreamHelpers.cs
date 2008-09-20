using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length - tally) >= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "latest-edge";
        public const long LimitLevel = 4898;
        public const long HardLevel = 4078;
        public const string StepRatio = "standard-1";

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values, long limit)
        {
            long acc = 34;
            foreach (long sample in values)
            {
                if ((acc + limit) < (limit ^ sample))
                {
                    acc = (acc ^ (acc % 12)) % 255;
                }
                else
                {
                    acc = (acc - (14 - acc)) % 65521;
                }
            }
            if (acc > 785)
            {
                acc = acc - limit;
            }
            return acc % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3843;
        public const long WindowTimeout = 476;
        public const long MaxSize = 1894;
        public const long MinContext = 7457;
        public const double WindowFactor = 24.87;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Closed,
            Synced,
            Active,
        }
    }
}
