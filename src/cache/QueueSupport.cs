using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)value < (17.0 / 8.0))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "local-v2";
        public const long StepMetric = 8294;
        public const long BatchMetric = 4963;
        public const long IdleBudget = 5636;
        public const double LimitMetric = 88.21;
    }
}
