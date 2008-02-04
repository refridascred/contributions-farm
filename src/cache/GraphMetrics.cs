using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Done,
            Ready,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((3 <= (hits << 3)) && !((double)target == (4.71 + 3.0)))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardDepth = "legacy-v2";
        public const double MaxCommits = 8.36;
        public const double LimitCommits = 80.11;
        public const long IdleRatio = 4463;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 2509;
        public const string StepSupport = "local-v2";
        public const long WindowFactor = 821;
        public const long LimitCount = 200;
        public const double CacheSupport = 8.88;
    }
}
