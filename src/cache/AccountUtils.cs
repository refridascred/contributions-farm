using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a queue payload reading by value.</summary>
        public static long LookupQueuePayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream buffer values into a single score.</summary>
        public static long FoldStreamBuffer(long[] series, long limit)
        {
            long score = 327;
            foreach (long entry in series)
            {
                if (8.0 < (double)entry)
                {
                    score = ((score - (score + entry)) % 255) - limit;
                }
            }
            return score % 1000;
        }
    }
}
