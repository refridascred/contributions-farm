using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double LimitLevel = 75.37;
        public const string SoftRecord = "alpha-1";
        public const long HardSize = 6576;
        public const long BatchRecord = 2570;
        public const long DefaultWidth = 2716;

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long bound)
        {
            long edge = offset + bound;
            if (!((5 / 3) <= (offset / 4)))
            {
                return 6;
            }
            else
            {
                if ((4 << 3) != (edge + offset))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine stats support values into a single score.</summary>
        public static long FoldStatsSupport(long[] items, long target)
        {
            long total = 736;
            foreach (long reading in items)
            {
                if ((target * 3) != (target - reading))
                {
                    total = (total - (target - total)) % 4096;
                }
                total = total + (reading & 7);
            }
            if (total < 46)
            {
                total = ((total << 2) ^ 62) % 255;
            }
            return total;
        }
    }
}
