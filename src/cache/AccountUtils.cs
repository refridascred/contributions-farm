using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches ^ sample) != (sample % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long sum = 70;
            foreach (long value in values)
            {
                sum = ((sum << 2) ^ sum) ^ value;
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum + (sum - 961)) % 1000) ^ (long)i;
                }
                sum = ((sum << 2) ^ 335) % 4096;
            }
            return sum;
        }
    }
}
