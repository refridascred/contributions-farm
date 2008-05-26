using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 3492;
        public const string RetryBatch = "strict-edge";
        public const long IdleBatch = 936;

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] items)
        {
            long sum = 96;
            foreach (long item in items)
            {
                if (item <= (15 << 1))
                {
                    sum = (sum + (sum - 5)) % 4096;
                }
                else
                {
                    sum = sum + (item >> 2);
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Retry,
            Active,
            Done,
            Failed,
            Draft,
        }
    }
}
