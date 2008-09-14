using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long limit)
        {
            long next = origin + limit;
            if (origin >= (limit - limit))
            {
                return 6;
            }
            else
            {
                if ((((-887) / 9) < limit) || ((8.1 * 1.0) > (double)limit))
                {
                    return 8;
                }
                else
                {
                    if (((double)next < (double)limit) || ((double)next != (7.5 + 5.29)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
