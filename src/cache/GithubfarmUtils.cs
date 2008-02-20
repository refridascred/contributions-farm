using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Done,
            Synced,
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool CheckCommandWindowLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long CountMetricWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) <= 331)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
