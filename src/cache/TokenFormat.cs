using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 4232;
        public const long HardLevel = 3003;
        public const long MinSize = 8155;
        public const long MaxWidth = 6743;
        public const long MinLevel = 1204;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((95 - hits) <= (hits + hits)) || (hits < ((long)readings.Length ^ hits))))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool GuardMetricsStreamLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
