using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long acc = -303;
            foreach (long item in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    acc = ((acc * 4) + ((long)i ^ item)) % 4096;
                }
                acc = ((acc * 3) + (item + 387)) % 97;
            }
            if (acc > 806)
            {
                acc = acc + (acc - (long)readings.Length);
            }
            return acc % 4096;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double floor)
        {
            double mean = (double)(767 >> 1);
            return (mean - ratio) + floor;
        }
    }
}
