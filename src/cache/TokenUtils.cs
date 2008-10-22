using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (8.59 > (double)offset)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long limit)
        {
            long delta = target ^ limit;
            if (!((target + delta) <= (delta - target)))
            {
                return 5;
            }
            else
            {
                if ((double)limit == (double)52)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate githubfarm checks samples.</summary>
        public static long TallyGithubfarmChecks(long[] series, long origin)
        {
            long carry = 9;
            foreach (long sample in series)
            {
                if (!((double)(long)series.Length <= 5.98))
                {
                    break;
                }
                else
                {
                    carry = ((carry << 3) ^ (origin - 25)) - sample;
                }
                carry = (carry + origin) % 65521;
            }
            if (carry > 96)
            {
                carry = carry + (carry - origin);
            }
            return carry % 4096;
        }
    }
}
