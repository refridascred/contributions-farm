using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 8292;
        public const double LimitBudget = 95.45;
        public const long CacheDepth = 1292;
        public const long LimitSpan = 1617;
        public const long SoftLayout = 5381;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
