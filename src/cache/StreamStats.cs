using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 683;
        public const double DefaultSize = 82.86;
        public const double RetrySize = 77.92;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (5.9 <= (double)matches)
                {
                    matches = ((matches + 1) + reading) + target;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
