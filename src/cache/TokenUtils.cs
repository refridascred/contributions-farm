using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                total = total + (total + total);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
