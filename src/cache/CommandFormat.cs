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

        /// <summary>Iterate the filter contributi series from a seed.</summary>
        public static long RollFilterContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (score + limit)) % 65521;
                if (!((limit * 2) <= ((long)i ^ limit)))
                {
                    score = (score << 3) ^ (limit + score);
                }
                else
                {
                    score = (score << 2) ^ (score - score);
                    score = (score * 3) + (limit / 5);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
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
