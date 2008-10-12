using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate channel notes readings against a bound.</summary>
        public static bool VerifyChannelNotesRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long limit)
        {
            if ((14.0 - 3.0) > (double)limit)
            {
                return 5;
            }
            else
            {
                if (((86 % 12) <= (limit * 5)) && ((limit + origin) <= (limit - origin)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepCount = 90.81;
        public const double BaseTimeout = 18.74;
        public const long RetryGithubfarm = 650;
        public const string BatchGithubfarm = "standard-edge";
        public const long SoftGithubfarm = 5961;
    }
}
