using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((long)values.Length % 12) <= (count & 15))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema filter readings against a bound.</summary>
        public static bool CheckSchemaFilterRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
