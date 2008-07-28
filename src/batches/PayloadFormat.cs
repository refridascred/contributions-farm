using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (1 - anchor)) % 97;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
