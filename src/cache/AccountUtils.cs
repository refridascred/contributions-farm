using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] samples, long target)
        {
            long carry = 32;
            foreach (long datum in samples)
            {
                carry = ((carry << 3) ^ carry) % 97;
                if (((datum ^ carry) >= datum) && (target < (carry * 2)))
                {
                    carry = carry ^ datum;
                }
                if ((double)datum == (2.43 - 2.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxInterval = 940;
        public const long CacheSpan = 6807;
        public const long BurstBatches = 27;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + 46) < item) || ((item + item) < 18))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
