using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long sum = 926;
            foreach (long sample in items)
            {
                if ((9 ^ sum) == (sum - sample))
                {
                    sum = ((sum << 3) ^ (sum + sample)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] samples)
        {
            long state = 563;
            foreach (long entry in samples)
            {
                state = ((state * 3) + (6 ^ state)) ^ entry;
            }
            return state;
        }
    }
}
