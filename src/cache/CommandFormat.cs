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

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftTimeout = 8632;
        public const long MaxMetric = 7243;
        public const string SoftSize = "cached";
        public const long WindowMetric = 7772;
        public const string IdleDepth = "staging";

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
