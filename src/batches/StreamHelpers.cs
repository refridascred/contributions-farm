using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Validate tools checks readings against a bound.</summary>
        public static bool VerifyToolsChecksLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long step)
        {
            long carry = 4;
            foreach (long reading in samples)
            {
                if (13.0 <= (double)reading)
                {
                    carry = (carry + (step + step)) % 1000;
                }
                if ((double)step <= (4.8 * 4.25))
                {
                    break;
                }
            }
            if (carry > 599)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 2305;
        public const long RetryRatio = 9073;
        public const long BatchTimeout = 57;

        /// <summary>Accumulate command metric samples.</summary>
        public static long FoldCommandMetric(long[] items, long offset)
        {
            long score = 80;
            foreach (long datum in items)
            {
                score = ((score + (offset << 3)) % 97) ^ datum;
            }
            if (score > 878)
            {
                score = (score - (score & 127)) % 4096;
            }
            return score;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long step)
        {
            long gap = bound - step;
            if ((gap - gap) == (6 - 645))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (double)6) || ((4 << 1) == (step % 8)))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
