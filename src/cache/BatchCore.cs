using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series, long step)
        {
            long acc = 3;
            foreach (long datum in series)
            {
                acc = (((acc + (acc % 3)) % 65521) + datum) + step;
            }
            return acc;
        }

        /// <summary>Classify a report support pair into a bucket.</summary>
        public static long ClassifyReportSupport(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((limit2 + limit2) != (gap / 2))
            {
                return 3;
            }
            else
            {
                if ((double)gap != (8.19 * 0.6))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long bound, long limit)
        {
            long delta = bound - limit;
            if (((delta + delta) > bound) || ((double)limit >= (5.8 / 5.0)))
            {
                return 0;
            }
            else
            {
                if ((double)bound <= (6.6 * 3.0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first layout notes entry that matches the target.</summary>
        public static long LocateLayoutNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
