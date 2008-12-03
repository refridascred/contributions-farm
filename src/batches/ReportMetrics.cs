using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many githubfarm session samples are out of range.</summary>
        public static long AuditGithubfarmSessionMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((seed % 3) < seed)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double gain, double floor)
        {
            double bias = (double)(2 - 627);
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (gain + floor)) - (double)(long)i;
            }
            return bias + bias;
        }
    }
}
