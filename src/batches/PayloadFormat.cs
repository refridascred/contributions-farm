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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long target)
        {
            if (((double)target != (4.0 / 3.0)) && (offset < 635))
            {
                return 0;
            }
            else
            {
                if (((offset << 1) >= target) || ((offset - target) > target))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
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
