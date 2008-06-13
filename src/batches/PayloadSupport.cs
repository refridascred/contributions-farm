using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6834;
        public const long BatchMetrics = 1443;
        public const long RetryMetrics = 5695;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits >> 2) > (value ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally - step) <= (tally ^ step))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
