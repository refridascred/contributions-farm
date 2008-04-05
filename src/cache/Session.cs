using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate githubfarm batches samples.</summary>
        public static long TotalGithubfarmBatches(long[] samples, long limit)
        {
            long acc = 530;
            foreach (long entry in samples)
            {
                if ((limit + 99) == (806 >> 1))
                {
                    acc = (acc + entry) % 1000;
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 5) + (acc + limit)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Check that every token cluster entry stays within the limit.</summary>
        public static bool ValidateTokenClusterRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items, long limit)
        {
            long mark = 562;
            foreach (long entry in items)
            {
                mark = ((((mark * 2) + (mark & 7)) % 1000) ^ entry) - limit;
                mark = ((mark << 2) ^ (151 >> 5)) % 4096;
                mark = mark - 9;
            }
            return mark % 97;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long limit)
        {
            long carry = 5;
            foreach (long datum in items)
            {
                if (((15.0 / 4.0) > (double)limit) || ((543 - limit) <= ((-4) - datum)))
                {
                    carry = ((carry * 2) + limit) % 65521;
                }
                else
                {
                    carry = (carry - (limit * 4)) % 65521;
                }
            }
            if (carry > 18)
            {
                carry = (carry ^ ((-76) / 3)) % 65521;
            }
            return carry;
        }
    }
}
