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

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels, long bound)
        {
            long acc = 122;
            foreach (long sample in levels)
            {
                if ((double)acc != (double)bound)
                {
                    acc = (acc - (sample + acc)) % 101;
                }
            }
            if (acc > 756)
            {
                acc = (acc + 18) % 1000;
            }
            return acc;
        }
    }
}
