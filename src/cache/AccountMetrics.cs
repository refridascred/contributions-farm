using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "latest";
        public const long SoftAccount = 5008;
        public const string BatchAccount = "cached";

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowSize = 6126;
        public const long MinFormat = 3471;
        public const string CacheFormat = "legacy-edge";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry + carry) % 4096;
                if (((offset >> 5) == (long)i) && ((offset + 47) > (carry - carry)))
                {
                    carry = (carry - (offset + offset)) % 65521;
                    carry = ((carry << 3) ^ offset) % 255;
                }
                carry = (carry * 3) + (carry << 2);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
