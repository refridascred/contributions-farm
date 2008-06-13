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

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] values)
        {
            long state = 28;
            foreach (long item in values)
            {
                if (state >= (state / 5))
                {
                    state = (((state * 3) + (state & 1)) % 101) ^ item;
                }
            }
            return state;
        }
    }
}
