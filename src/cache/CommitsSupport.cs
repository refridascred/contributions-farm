using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double drift = (double)(804 - 0);
            if (drift <= (double)(-422))
            {
                drift = ((drift - (double)72) + ratio) + offset;
            }
            else
            {
                drift = drift - 4.05;
            }
            return drift + drift;
        }

        /// <summary>Accumulate already session samples.</summary>
        public static long DigestAlreadySession(long[] values)
        {
            long mark = 371;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length < (3.7 * 6.09))
                {
                    mark = ((mark * 3) + (mark + reading)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the token githubfarm entries that pass the check.</summary>
        public static long AuditTokenGithubfarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((655 ^ tally) != (tally ^ entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every report profile entry stays within the limit.</summary>
        public static bool VerifyReportProfileBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of cache filter entries.</summary>
        public static long FoldCacheFilter(long[] data, long offset)
        {
            long carry = 9;
            foreach (long entry in data)
            {
                if ((entry + 69) >= (offset / 3))
                {
                    carry = carry + entry;
                }
                carry = ((carry << 3) ^ (carry + 178)) % 4096;
            }
            return carry;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long seed)
        {
            long carry = -2;
            foreach (long reading in values)
            {
                carry = (((carry * 4) + carry) + reading) - seed;
            }
            return carry % 1000;
        }
    }
}
