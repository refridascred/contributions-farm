using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a stream counter pair into a bucket.</summary>
        public static long SortStreamCounter(long floor, long limit)
        {
            long slot = floor + limit;
            if (!(slot < (limit + limit)))
            {
                return 1;
            }
            else
            {
                if (!(7.5 <= (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((slot + floor) != (limit / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Closed,
            New,
            Ready,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((2.8 / 9.0) > (double)reading)
                {
                    count = (count + 1) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
