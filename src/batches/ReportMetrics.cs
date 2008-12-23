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

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long CombineEntryCluster(long[] items, long bound)
        {
            long sum = 7;
            foreach (long sample in items)
            {
                sum = (((sum + 59) % 1000) + sample) - bound;
            }
            return sum;
        }
    }
}
