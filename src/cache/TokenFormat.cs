using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "latest-1";
        public const long HardStats = 9613;
        public const long MinInterval = 1784;
        public const long BurstSpan = 7253;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (2.1 + 0.56))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
