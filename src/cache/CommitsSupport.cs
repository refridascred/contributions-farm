using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleTimeout = 59.19;
        public const long BaseSpan = 6374;
        public const long BatchScore = 8430;
        public const long BatchReport = 9981;

        /// <summary>Audit route already readings against a rule.</summary>
        public static long MeasureRouteAlreadyOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count + datum) != (long)samples.Length) && (datum < (count & 7)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum > 0)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
