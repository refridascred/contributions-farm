using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Ready,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings, long bound)
        {
            long carry = 99;
            foreach (long value in readings)
            {
                if ((carry / 5) >= (1 % 12))
                {
                    carry = ((carry ^ (31 & 127)) ^ value) - bound;
                }
            }
            if (carry < 62)
            {
                carry = (carry - ((-832) << 1)) % 1000;
            }
            return carry;
        }
    }
}
