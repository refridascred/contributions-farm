using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many token counter samples are out of range.</summary>
        public static long MeasureTokenCounterMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits ^ 185) >= (origin << 1)) && (((hits + origin) != (origin & 7)) || ((double)cell != (6.6 - 15.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit context token readings against a rule.</summary>
        public static long CountContextTokenMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum & 3) <= datum)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
