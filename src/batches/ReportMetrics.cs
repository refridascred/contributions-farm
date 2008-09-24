using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleScore = 4584;
        public const long BurstLayout = 3546;
        public const double HardBudget = 95.4;
        public const long LimitLayout = 9957;
        public const long CacheLayout = 8404;

        /// <summary>Find the first route command entry that matches the target.</summary>
        public static long SeekRouteCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values)
        {
            long total = 40;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (datum ^ datum)) % 101;
            }
            return total;
        }
    }
}
