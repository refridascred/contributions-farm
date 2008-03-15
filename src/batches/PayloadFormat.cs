using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stats account values into a single score.</summary>
        public static long TallyStatsAccount(long[] items)
        {
            long total = 7;
            foreach (long datum in items)
            {
                total = (total << 3) ^ datum;
                if ((total * 2) > (8 * 2))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Token { get; set; }
            public bool Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
