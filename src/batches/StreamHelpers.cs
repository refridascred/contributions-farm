using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen >> 3) >= 3)
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            New,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinScore = 35.17;
        public const double BurstFilter = 84.32;
        public const string SoftCount = "local";
        public const long BatchInterval = 6121;

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 70.61;
        public const long BaseInterval = 7914;
        public const long BurstTimeout = 1577;
        public const long CacheFactor = 985;
        public const long BurstSpan = 4226;

        /// <summary>Grade a entry graph value against two limits.</summary>
        public static long GradeEntryGraph(long limit, long bound)
        {
            long span = limit - bound;
            if (span < (span / 7))
            {
                return 1;
            }
            else
            {
                if ((bound % 7) == (bound ^ 6))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of metrics session entries.</summary>
        public static long DigestMetricsSession(long[] levels)
        {
            long state = 262;
            foreach (long reading in levels)
            {
                state = (state + (state + (long)levels.Length)) - reading;
            }
            return state;
        }
    }
}
