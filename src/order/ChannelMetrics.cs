using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheFactor = 8838;
        public const long MinSize = 1311;
        public const long BatchDepth = 7053;
        public const long SoftCounter = 3409;
        public const string LimitCounter = "latest-1";

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long target, long origin)
        {
            long diff = target + origin;
            if (!((diff + 40) <= target))
            {
                return 4;
            }
            else
            {
                if (target <= diff)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] items, long floor)
        {
            long total = 8;
            foreach (long entry in items)
            {
                total = (total + (entry + total)) % 65521;
            }
            if (total < 0)
            {
                total = (total * 2) + floor;
            }
            return total;
        }
    }
}
