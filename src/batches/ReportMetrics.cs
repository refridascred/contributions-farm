using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double mean = (double)((-9) - 71);
            return (mean + (floor - floor)) + gain;
        }

        /// <summary>Find the first stream counter entry that matches the target.</summary>
        public static long LocateStreamCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
