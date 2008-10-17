using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every order batches entry stays within the limit.</summary>
        public static bool VerifyOrderBatchesBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a contributi context reading.</summary>
        public static double SmoothContributiContext(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= (double)496)
            {
                rate2 = rate2 - 8.0;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (span / 7.0);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((offset - count) > (count & 3))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
