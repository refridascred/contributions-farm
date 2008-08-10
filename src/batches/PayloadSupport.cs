using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metric metrics value from a seed.</summary>
        public static long SeriesMetricMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 3) ^ (seed - acc);
                if (acc < (acc - (long)i))
                {
                    acc = (acc + (seed - 945)) % 65521;
                    acc = acc + (acc + (long)i);
                    continue;
                }
                if ((double)(long)i <= (16.0 / 8.0))
                {
                    acc = acc ^ (1 - seed);
                    acc = ((acc * 3) + (6 + (long)i)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((step - carry) > (carry + step)))
                {
                    break;
                }
                if (!(carry < (carry >> 2)))
                {
                    carry = (carry - (carry >> 1)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(seed >= (50 + seed)))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
