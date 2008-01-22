using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i == (floor ^ sum))
                {
                    sum = sum ^ (floor - (long)i);
                }
                else
                {
                    sum = (sum + ((long)i - sum)) % 65521;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 2743;
        public const long HardWidth = 5739;
        public const string CacheLevel = "primary";
        public const string StepBudget = "cached-v2";

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                acc = (acc + (acc - cell)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Fold a list of profile githubfarm readings.</summary>
        public static long DigestProfileGithubfarm(long[] samples, long target)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                if (acc < target)
                {
                    acc = (acc - item) % 101;
                }
                if (item <= (acc << 1))
                {
                    acc = (acc - (acc % 97)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
