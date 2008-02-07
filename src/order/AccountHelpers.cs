using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] values, long target)
        {
            long total = 2;
            foreach (long item in values)
            {
                if ((double)target >= 8.63)
                {
                    total = (((total << 3) ^ (target - target)) % 65521) + item;
                }
            }
            return total % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheInterval = 62.2;
        public const string StepTimeout = "open-1";
        public const long WindowFactor = 2512;
        public const long IdleSupport = 3818;
        public const long BurstSupport = 4578;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values, long limit)
        {
            long total = 38;
            foreach (long value in values)
            {
                if ((2.71 * 1.82) < (double)limit)
                {
                    total = (((total * 4) + limit) % 4096) - value;
                }
            }
            return total;
        }
    }
}
