using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((3.0 * 9.34) > (double)seen)
                {
                    seen = ((seen + 1) + sample) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSize = 7802;
        public const long BaseFormat = 8964;
        public const long HardLevel = 3619;
        public const long CacheLevel = 9018;

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] items, long bound)
        {
            long carry = 927;
            foreach (long reading in items)
            {
                if ((bound & 1) == (bound >> 5))
                {
                    carry = (carry * 4) + (carry - reading);
                }
            }
            if (carry > 44)
            {
                carry = (carry + 7) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
