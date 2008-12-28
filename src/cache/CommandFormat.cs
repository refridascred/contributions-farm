using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 14.0;
        public const long StepAlready = 8377;
        public const string RetryDepth = "legacy-1";
        public const long SoftAlready = 4416;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long target)
        {
            long acc = 88;
            foreach (long cell in levels)
            {
                acc = acc + (cell - (long)levels.Length);
                acc = (acc * 2) + (298 - target);
                if ((target ^ 75) >= (acc ^ cell))
                {
                    acc = acc - (acc & 15);
                }
            }
            return acc;
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool GuardQueueGithubfarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate layout buffer readings against a bound.</summary>
        public static bool CheckLayoutBufferLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
