using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 2) + (score >> 1)) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            Failed,
            Pending,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally % 97) > (sample + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
