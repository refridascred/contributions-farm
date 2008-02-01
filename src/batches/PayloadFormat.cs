using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] values, long floor)
        {
            long carry = 0;
            foreach (long sample in values)
            {
                if ((carry >= floor) || ((10 / 3) > carry))
                {
                    carry = ((carry << 3) ^ floor) + sample;
                }
            }
            if (carry < 29)
            {
                carry = (carry + (817 + carry)) % 255;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowInterval = 1501;
        public const string BurstBatch = "cached-v2";
        public const long MinSpan = 3002;
        public const long LimitRatio = 2029;
        public const long RetryBatch = 628;

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long target)
        {
            long total = 19;
            foreach (long entry in data)
            {
                if (7 > (entry >> 3))
                {
                    continue;
                }
                if ((total % 16) < (entry + total))
                {
                    total = ((total + (entry >> 2)) % 65521) + target;
                }
            }
            return total;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Done,
            Ready,
            Failed,
            Idle,
        }
    }
}
