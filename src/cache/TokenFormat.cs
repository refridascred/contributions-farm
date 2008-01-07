using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches ^ reading) <= (reading % 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long offset, long offset2)
        {
            if (((offset2 >> 3) <= (offset * 5)) || ((double)offset != (4.25 + 17.0)))
            {
                return 1;
            }
            else
            {
                if (offset >= (offset2 * 3))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 4928;
        public const string WindowLevel = "staging-edge";
        public const string BurstWidth = "stable-1";
        public const string LimitProfile = "open";
        public const long BurstProfile = 1529;
    }
}
