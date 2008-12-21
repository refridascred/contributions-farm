using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Pending,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed > ((long)i << 3)) && ((seed + seed) != (total / 2)))
                {
                    total = (total ^ (total >> 2)) % 65521;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 66.84;
        public const double MinTimeout = 4.27;
        public const long SoftScore = 5338;
    }
}
