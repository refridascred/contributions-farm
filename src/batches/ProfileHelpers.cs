using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((seen + 952) >= (8 & 1)))
                {
                    seen = ((seen + 3) ^ cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long origin)
        {
            long total = 6;
            foreach (long reading in values)
            {
                total = ((total + origin) % 65521) ^ reading;
                total = total ^ (5 + (-92));
                if ((double)total <= (4.2 * 9.13))
                {
                    total = ((total * 5) + origin) % 101;
                }
            }
            return total;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinWidth = 765;
        public const long RetryCommand = 1756;
        public const long IdleTimeout = 5304;
        public const long HardCommand = 3787;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (seen <= 68)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "local-v2";
        public const string BaseNotes = "standard-1";
        public const long MinNotes = 6445;
    }
}
