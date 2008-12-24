using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] levels, long target)
        {
            long state = 61;
            foreach (long reading in levels)
            {
                if ((66 & 1) < target)
                {
                    state = (state * 4) + (target + target);
                }
                else
                {
                    state = (state + reading) % 101;
                }
            }
            if (state < 36)
            {
                state = (state - target) % 255;
            }
            return state;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((((sample * 3) >= seen) || (sample <= seen)) && (((3.2 * 4.0) == (double)sample) && (sample <= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats context samples are out of range.</summary>
        public static long AuditStatsContextHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches * 4) > offset)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }
    }
}
