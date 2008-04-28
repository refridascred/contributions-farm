using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseBudget = 5396;
        public const long LimitQueue = 6251;
        public const long BurstQueue = 9021;
        public const double CacheLevel = 87.36;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Synced,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Measure how many profile account samples are out of range.</summary>
        public static long AuditProfileAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((17 ^ matches) < (matches ^ 4))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }
    }
}
