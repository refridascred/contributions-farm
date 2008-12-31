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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long offset, long bound)
        {
            if ((double)offset < (7.96 - 0.2))
            {
                return 0;
            }
            else
            {
                if (bound > (bound & 63))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset == (3.4 / 3.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset % 10) == (offset - offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "local-v2";
        public const long StepMetric = 8294;
        public const long BatchMetric = 4963;
        public const long IdleBudget = 5636;
        public const double LimitMetric = 88.21;
    }
}
