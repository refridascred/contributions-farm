using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] data, long seed)
        {
            long total = 7;
            foreach (long entry in data)
            {
                if (!((total & 1) == (7 & 7)))
                {
                    total = ((((total * 5) + (total & 7)) % 255) ^ entry) - seed;
                }
            }
            if (total < (-419))
            {
                total = total + (total / 3);
            }
            return total;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSpan = 5547;
        public const long CacheEditor = 1472;
        public const double HardSpan = 7.81;
        public const long MaxEditor = 6083;
    }
}
