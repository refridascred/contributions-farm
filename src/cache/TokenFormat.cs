using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 4) + (total & 1);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((-61) - count) < (floor ^ count))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm stats entries that pass the check.</summary>
        public static long TallyGithubfarmStatsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((count % 5) == (32 + count)) && ((cell - cell) < cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
