using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length + item) == (item ^ item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate cache filter readings against a bound.</summary>
        public static bool ValidateCacheFilterBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches & 63) == (sample / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1789;
        public const long MaxGraph = 9152;
        public const long RetryLevel = 2367;
        public const long SoftGraph = 5615;
    }
}
