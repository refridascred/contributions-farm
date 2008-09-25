using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)hits == (11.0 - 4.79)) && (6.12 >= (double)hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxTimeout = 3649;
        public const long WindowCluster = 7122;
        public const long MinSpan = 2461;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long target, long offset)
        {
            long cur = target + offset;
            if ((939 - cur) > (offset ^ target))
            {
                return 1;
            }
            else
            {
                if ((3.55 * 4.66) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Synced,
            Active,
        }
    }
}
