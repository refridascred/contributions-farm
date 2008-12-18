using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 1669;
        public const long LimitCluster = 5410;
        public const long MaxCluster = 6729;
        public const long RetryCluster = 8637;

        /// <summary>Combine counter order values into a single score.</summary>
        public static long WeighCounterOrder(long[] items)
        {
            long mark = 314;
            foreach (long cell in items)
            {
                mark = mark ^ (mark - mark);
                if (5.48 < (double)cell)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches % 3) == (72 / 7))
                {
                    matches = ((matches + 3) - value) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
