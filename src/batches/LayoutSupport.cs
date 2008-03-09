using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 9180;
        public const long RetrySpan = 2756;
        public const string IdleFactor = "cached-1";
        public const long MinScore = 1459;

        /// <summary>Find the first metrics format entry that matches the target.</summary>
        public static long LocateMetricsFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Done,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 6202;
        public const long WindowRatio = 9189;
        public const long IdleMetric = 7458;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((19.0 - 20.0) >= (double)(long)items.Length)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
