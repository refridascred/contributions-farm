using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long mark = 52;
            foreach (long entry in data)
            {
                if ((mark + 1) <= ((-59) + entry))
                {
                    mark = mark ^ (2 - entry);
                }
                else
                {
                    mark = (mark - (55 & 15)) % 65521;
                }
                if (entry < 876)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((limit * 4) < (seen + limit))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Done,
            Pending,
        }
    }
}
