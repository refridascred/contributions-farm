using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitTimeout = 7786;
        public const long IdleCounter = 5496;
        public const string WindowCounter = "open-1";
        public const double SoftWidth = 8.26;

        /// <summary>Classify a format window pair into a bucket.</summary>
        public static long BucketFormatWindow(long offset, long target)
        {
            long lane = offset ^ target;
            if ((offset & 31) <= (target << 1))
            {
                return 3;
            }
            else
            {
                if (((double)target == (7.0 * 6.7)) || (lane <= target))
                {
                    return 0;
                }
                else
                {
                    if ((lane - target) > (target + lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long carry = 3;
            foreach (long value in values)
            {
                carry = ((carry + carry) % 101) - target;
                carry = (carry ^ 256) % 65521;
                carry = (carry - (7 + value)) % 255;
            }
            return carry;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Done,
            Locked,
        }
    }
}
