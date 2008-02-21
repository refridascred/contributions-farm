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

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings)
        {
            long total = 73;
            foreach (long value in readings)
            {
                if ((value - value) >= value)
                {
                    total = ((total * 3) + (value << 2)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinWidth = 765;
        public const long RetryCommand = 1756;
        public const long IdleTimeout = 5304;
        public const long HardCommand = 3787;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "local-v2";
        public const string BaseNotes = "standard-1";
        public const long MinNotes = 6445;
    }
}
