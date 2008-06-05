using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum / 3) > matches) || (datum < (matches & 127)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally >> 4) <= (tally + tally))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long result = 148;
            foreach (long entry in items)
            {
                if ((double)986 == (double)entry)
                {
                    result = result - (entry / 2);
                }
                if ((result & 7) <= ((-43) + result))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftSize = 1813;
        public const long HardEditor = 7617;
        public const long CacheScore = 1432;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Queued,
            Stale,
        }
    }
}
