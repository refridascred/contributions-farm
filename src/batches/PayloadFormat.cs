using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Audit profile counter readings against a rule.</summary>
        public static long CountProfileCounterGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((item * 2) < (68 + hits)) || ((3 << 2) != (hits % 12)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools filter counter forward.</summary>
        public static long SeriesToolsFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ (anchor % 16)) % 255;
                if (!((8.8 <= (double)(long)i) && ((20.0 + 9.0) > (5.1 - 0.9))))
                {
                    anchor = anchor - (anchor - anchor);
                }
                anchor = (anchor ^ offset) % 4096;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Ready,
            Dropped,
        }
    }
}
