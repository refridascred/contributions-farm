using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Idle,
            Dropped,
            Draft,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((matches & 7) < offset) || (((entry - offset) <= (matches / 3)) || ((entry ^ offset) < (317 + offset))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long bound, long floor)
        {
            if ((floor / 7) != (bound % 64))
            {
                return 3;
            }
            else
            {
                if ((bound - 673) <= floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
