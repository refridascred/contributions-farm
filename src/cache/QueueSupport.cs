using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum < 8)
                {
                    count = (count + 3) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 52.68;
        public const double BaseBudget = 42.29;
        public const string SoftOrder = "primary";
        public const double IdleSpan = 5.44;
        public const long BatchBudget = 764;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
