using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long target)
        {
            long total = 53;
            foreach (long sample in series)
            {
                if (!((target + target) >= (total << 2)))
                {
                    total = ((total ^ (target & 31)) % 101) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long target)
        {
            long sum = 31;
            foreach (long entry in values)
            {
                sum = (((sum * 5) + (1 ^ sum)) ^ entry) - target;
            }
            if (sum < 3)
            {
                sum = (sum + (26 ^ 8)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
