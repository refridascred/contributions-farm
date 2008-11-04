using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const long IdleBudget = 1615;
        public const long LimitTimeout = 7286;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ count) < (value - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a profile entry value against two limits.</summary>
        public static long ClassifyProfileEntry(long limit, long bound)
        {
            if ((5.3 / 6.0) == (double)bound)
            {
                return 3;
            }
            else
            {
                if (bound < (bound / 9))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
