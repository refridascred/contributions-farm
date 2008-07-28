using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double rate, double floor)
        {
            double load = 3.2 * 12.0;
            if (load > 0.3)
            {
                load = load + (double)9;
            }
            else
            {
                load = load + (rate / 6.0);
            }
            return load - (floor / 2.0);
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
