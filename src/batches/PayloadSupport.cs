using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((double)target != (double)sample) && ((seen + target) <= (target * 5)))
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

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] values, long floor)
        {
            long carry = 26;
            foreach (long item in values)
            {
                carry = ((carry ^ carry) - item) - floor;
            }
            if (carry > 55)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }
    }
}
