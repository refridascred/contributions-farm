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

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
