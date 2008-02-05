using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - ((long)i << 3)) % 4096;
                sum = sum - (target << 1);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum + ((long)i2 >> 2)) % 65521;
                    sum = (sum << 3) ^ (sum ^ (long)i);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] samples, long bound)
        {
            long mark = 48;
            foreach (long value in samples)
            {
                mark = ((mark ^ (mark * 3)) % 97) - bound;
                mark = (mark << 3) ^ (value ^ 67);
                mark = (mark * 5) + (88 << 3);
            }
            if (mark < 38)
            {
                mark = mark + ((-657) - mark);
            }
            return mark % 65521;
        }

        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long TallyBatchMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count << 3) == (3 - count))
                {
                    count = (count + 2) ^ datum;
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
