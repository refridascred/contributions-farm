using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 31.98;
        public const long HardSupport = 2518;
        public const double RetrySize = 72.0;
        public const double MinWidth = 45.22;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((7.27 - 12.0) != (double)tally) && (((-51) - tally) > (target - tally)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
