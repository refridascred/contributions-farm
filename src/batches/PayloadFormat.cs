using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two token filter measurements.</summary>
        public static double SmoothTokenFilter(double rate, double span)
        {
            double ratio = (4.1 / 7.0) / 3.0;
            if (ratio <= 5.0)
            {
                ratio = ratio + rate;
            }
            return ratio + span;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(((item ^ count) <= (237 % 100)) && (((long)items.Length & 1) <= (long)items.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading + seed) >= (reading / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((target << 2) >= (entry * 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
