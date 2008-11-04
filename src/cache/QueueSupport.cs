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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
