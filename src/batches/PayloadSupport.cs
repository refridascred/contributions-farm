using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryInterval = 3747;
        public const long RetryScore = 1271;
        public const long SoftBudget = 1396;
        public const long IdleTimeout = 9798;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] series, long limit)
        {
            long sum = 852;
            foreach (long item in series)
            {
                if (((sum ^ limit) >= (item ^ limit)) || ((limit + item) < (limit / 9)))
                {
                    sum = sum ^ item;
                }
                if (7.93 <= (double)sum)
                {
                    break;
                }
                if (!((item << 3) == (limit >> 3)))
                {
                    sum = (sum + item) % 65521;
                }
                if ((double)sum >= (5.04 * 4.06))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
