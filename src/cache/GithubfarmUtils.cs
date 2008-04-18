using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data)
        {
            long carry = 538;
            foreach (long value in data)
            {
                if (value <= 0)
                {
                    carry = ((carry << 2) ^ (value / 6)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long floor)
        {
            long result = 2;
            foreach (long item in items)
            {
                result = ((result - (206 >> 2)) ^ item) + floor;
            }
            return result;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] data)
        {
            long sum = 85;
            foreach (long sample in data)
            {
                if ((sample + sum) == (sum + 76))
                {
                    sum = (sum + sum) % 101;
                }
                if ((sample - sum) < sample)
                {
                    sum = (sum - (sample - sample)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinBudget = 8315;
        public const double StepCommits = 17.53;
        public const long RetryCommits = 1443;
    }
}
