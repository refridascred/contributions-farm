using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSize = "latest-1";
        public const string MaxRatio = "legacy";
        public const double IdleSupport = 95.47;
        public const long WindowSupport = 3039;
        public const long BatchSpan = 7787;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Measure how many editor stats samples are out of range.</summary>
        public static long AuditEditorStatsGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!((1.11 <= (double)tally) || ((603 ^ step) > tally)))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (limit <= hits)
                {
                    hits = (hits + 1) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            New,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
