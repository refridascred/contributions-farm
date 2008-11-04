using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 41.46;
        public const long StepTimeout = 166;
        public const long BatchMetrics = 4992;
        public const string BurstMetrics = "latest-v2";
        public const long MinMetrics = 9811;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= (value << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long offset)
        {
            long acc = 685;
            foreach (long value in items)
            {
                acc = acc - (0 + offset);
                acc = (acc ^ (offset - acc)) % 97;
                if ((double)value < (double)acc)
                {
                    acc = ((acc * 3) + (offset << 3)) % 255;
                }
            }
            return acc;
        }
    }
}
