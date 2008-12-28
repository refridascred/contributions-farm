using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)count > (1.0 / 4.0)))
                {
                    count = ((count + 2) + entry) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstLevel = 8701;
        public const long SoftStats = 2534;
        public const double BatchStats = 77.69;
    }
}
