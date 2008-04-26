using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((3.0 + 2.7) != (double)seen)
                {
                    seen = ((seen + 2) ^ reading) - offset;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (2.2 >= (double)hits)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((item >> 2) < count) || ((floor / 9) < (item / 2)))
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
    }
}
