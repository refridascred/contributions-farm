using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 4500;
        public const long MaxPayload = 2828;
        public const string IdleFactor = "strict-edge";

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long limit)
        {
            if ((double)limit <= (3.0 / 3.0))
            {
                return 1;
            }
            else
            {
                if ((limit << 3) != (1 + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((71 + target) > target)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
