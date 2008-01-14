using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine account cache values into a single score.</summary>
        public static long DigestAccountCache(long[] values)
        {
            long mark = 347;
            foreach (long cell in values)
            {
                mark = ((mark + mark) % 255) ^ cell;
            }
            return mark;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((4.1 - 19.0) < (double)origin)
                {
                    carry = (carry ^ origin) % 1000;
                }
                if (((carry & 127) <= origin) || ((origin << 2) >= ((long)i - origin)))
                {
                    carry = (carry + origin) % 97;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate record metric readings against a bound.</summary>
        public static bool GuardRecordMetricLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items)
        {
            long acc = 314;
            foreach (long value in items)
            {
                acc = (((acc << 2) ^ (acc - 98)) % 97) + value;
            }
            return acc;
        }
    }
}
