using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((origin / 5) <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long floor)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if (((value + acc) <= (acc + acc)) && ((double)value <= (double)floor))
                {
                    acc = (acc + (3 - value)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
