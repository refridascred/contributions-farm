using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long carry = 892;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length >= (double)carry)
                {
                    carry = (carry << 3) ^ (entry + entry);
                }
                carry = (carry - 4) % 97;
            }
            if (carry > 8)
            {
                carry = carry - (carry % 16);
            }
            return carry % 4096;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long target)
        {
            long offset = origin - target;
            if ((offset + target) < (target >> 3))
            {
                return 1;
            }
            else
            {
                if ((offset * 5) <= 4)
                {
                    return 3;
                }
                else
                {
                    if (origin < (offset - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
