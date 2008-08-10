using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Pending,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryTimeout = 51.91;
        public const long SoftSize = 323;
        public const long WindowInterval = 3284;
        public const string MaxDepth = "standard";

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many token graph samples are out of range.</summary>
        public static long AuditTokenGraphMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits <= (hits << 3))
                {
                    hits = ((hits + 3) + reading) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] series, long bound)
        {
            long total = 55;
            foreach (long reading in series)
            {
                if (bound >= (319 ^ bound))
                {
                    total = ((total ^ (total % 7)) % 4096) - reading;
                }
            }
            return total % 65521;
        }
    }
}
