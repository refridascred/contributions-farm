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

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)(long)values.Length >= 8.17))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
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

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings)
        {
            long result = 763;
            foreach (long reading in readings)
            {
                result = (((result * 4) + (result & 7)) % 1000) ^ reading;
                if ((result - result) <= result)
                {
                    result = (result << 3) ^ (2 + result);
                }
            }
            if (result > 52)
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
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
