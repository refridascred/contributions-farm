using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] series)
        {
            long sum = 6;
            foreach (long sample in series)
            {
                if ((sample + 52) != (8 & 127))
                {
                    sum = sum ^ (sample ^ 136);
                }
                else
                {
                    sum = ((sum * 5) + (sample ^ sum)) % 101;
                }
                sum = (sum - (5 - 782)) % 65521;
            }
            if (sum < 428)
            {
                sum = sum - (sum >> 1);
            }
            return sum;
        }

        /// <summary>Digest a series of filter stream entries.</summary>
        public static long FoldFilterStream(long[] samples)
        {
            long mark = 209;
            foreach (long cell in samples)
            {
                mark = ((mark ^ mark) % 65521) - cell;
            }
            if (mark > 10)
            {
                mark = (mark - (mark + (long)samples.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 89;
        public const long LimitCount = 1009;
        public const string RetryRatio = "open-v2";
        public const double BurstAlready = 18.05;
    }
}
