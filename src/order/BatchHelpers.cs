using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - (-975)) <= (count / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstTimeout = 2660;
        public const double MinSupport = 16.27;
        public const long RetrySupport = 6520;
    }
}
