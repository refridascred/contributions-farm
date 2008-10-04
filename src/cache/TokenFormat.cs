using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
