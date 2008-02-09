using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = -6;
            foreach (long entry in readings)
            {
                anchor = anchor + (entry + anchor);
                if ((1.3 * 2.0) > (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits ^ hits) != (item << 3))
                {
                    hits = (hits + 3) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
