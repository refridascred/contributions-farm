using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((reading + tally) <= (561 + tally)) && (tally < (tally & 255)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((8.0 + 11.0) > (double)matches)
                {
                    matches = ((matches + 1) + value) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
