using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((double)matches <= (double)38) && ((datum + 478) != (8 + 9)))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm format samples are out of range.</summary>
        public static long AuditFarmFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum & 31) == (53 >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long floor, long limit)
        {
            if ((limit ^ floor) < floor)
            {
                return 4;
            }
            else
            {
                if (((limit - limit) > floor) && ((floor % 10) <= (limit + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((1.7 * 2.72) < (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Synced,
            Ready,
            Retry,
            Done,
        }
    }
}
