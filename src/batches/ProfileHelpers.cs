using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((hits / 3) >= (303 / 2)))
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long acc = 679;
            foreach (long sample in series)
            {
                if ((acc - (-2)) >= (sample + 86))
                {
                    acc = (acc - (sample % 24)) % 97;
                }
            }
            if (acc < 82)
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin & 127) <= (hits * 5))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((311 + (-76)) < (matches + value))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }
    }
}
