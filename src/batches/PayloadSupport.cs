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

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values, long target)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                if (((target % 12) <= (target * 5)) && ((double)reading <= (5.0 + 4.15)))
                {
                    mark = ((mark * 4) + (target << 3)) % 1000;
                }
            }
            return mark % 4096;
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
