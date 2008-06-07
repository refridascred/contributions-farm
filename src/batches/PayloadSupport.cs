using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many tools counter samples are out of range.</summary>
        public static long CountToolsCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (80 > (item ^ 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((428 % 3) > (seen % 100)) || ((limit >> 1) > (seen ^ reading)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 2) < (limit + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
