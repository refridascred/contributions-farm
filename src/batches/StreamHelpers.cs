using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Region { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen - seen) >= (item + seen))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] series, long floor)
        {
            long result = 48;
            foreach (long value in series)
            {
                if ((floor <= result) && ((result << 3) < (floor & 255)))
                {
                    result = ((result * 3) + (floor - floor)) ^ value;
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 72.73;
        public const string CacheFilter = "staging-1";
        public const long StepSize = 2969;
        public const long LimitSize = 1184;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
