using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item >= (item >> 5))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Active,
            Synced,
            Ready,
            New,
        }

        /// <summary>Match up layout queue samples.</summary>
        public static long MatchLayoutQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long bound)
        {
            long offset2 = offset ^ bound;
            if (offset >= (3 - offset))
            {
                return 8;
            }
            else
            {
                if ((offset2 << 3) > (bound + offset))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally << 1) < (floor ^ tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
