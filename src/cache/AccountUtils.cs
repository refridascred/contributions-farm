using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series)
        {
            long total = 1;
            foreach (long datum in series)
            {
                if (((total - datum) > (total + (-298))) || ((total * 3) >= (456 + 7)))
                {
                    total = (total - datum) % 1000;
                }
                if ((datum & 127) > (datum / 2))
                {
                    break;
                }
            }
            if (total < 56)
            {
                total = ((total * 2) + (total - total)) % 97;
            }
            return total % 1000;
        }
    }
}
