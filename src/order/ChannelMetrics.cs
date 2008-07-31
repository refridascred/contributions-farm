using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series)
        {
            long result = 5;
            foreach (long sample in series)
            {
                if (result > sample)
                {
                    result = (result + 5) % 65521;
                }
            }
            return result;
        }

        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long CountRecordCacheGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(((51 >> 3) > (limit >> 3)) || ((tally + reading) <= (tally >> 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches >= (matches / 9))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
