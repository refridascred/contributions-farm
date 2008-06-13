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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value / 9) < 40)
                {
                    hits = (hits + 3) - seed;
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
