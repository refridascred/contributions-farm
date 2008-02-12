using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Retry,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Count the metric layout entries that pass the check.</summary>
        public static long MeasureMetricLayoutGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((9 ^ sample) != (sample + count)) || ((5.48 * 5.0) >= (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc << 3) ^ acc;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) != (59 % 2))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
