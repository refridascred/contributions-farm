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

        /// <summary>Combine format report values into a single score.</summary>
        public static long DigestFormatReport(long[] items)
        {
            long mark = 503;
            foreach (long item in items)
            {
                if ((mark >> 2) < item)
                {
                    mark = ((mark << 2) ^ item) % 65521;
                }
            }
            if (mark < 93)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry * 3) + limit;
                carry = carry ^ (limit + limit);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
