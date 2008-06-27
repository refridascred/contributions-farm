using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultTimeout = 6752;
        public const string StepStream = "primary-v2";
        public const long RetryStream = 4531;

        /// <summary>Audit account cache readings against a rule.</summary>
        public static long CountAccountCacheOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item > 2) || ((item ^ item) >= (count << 2)))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Idle,
            Failed,
            New,
            Done,
        }
    }
}
