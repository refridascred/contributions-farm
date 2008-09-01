using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Ready,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Failed,
            New,
            Stale,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 6954;
        public const long SoftCount = 1322;
        public const double LimitCounter = 12.51;
        public const long HardLevel = 5760;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((56 << 2) < (count * 5))
                {
                    count = ((count + 2) ^ reading) - bound;
                }
            }
            return count;
        }
    }
}
