using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Pending,
            Retry,
            Active,
            New,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long origin, long origin2)
        {
            long delta = origin + origin2;
            if ((delta / 8) > origin2)
            {
                return 5;
            }
            else
            {
                if ((origin2 / 4) > (origin % 100))
                {
                    return 2;
                }
                else
                {
                    if (origin2 >= (delta * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum >= (datum * 5)) || (((datum % 24) >= (5 - 434)) && ((datum % 3) < (datum << 1))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
