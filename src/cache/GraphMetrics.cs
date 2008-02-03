using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double weight, double floor)
        {
            double bias = (double)(748 * 4);
            if (bias < (bias * 4.7))
            {
                bias = bias - floor;
            }
            else
            {
                bias = bias + weight;
            }
            return bias - (floor + 10.0);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many githubfarm cluster samples are out of range.</summary>
        public static long AuditGithubfarmClusterOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value & 255) < step) && (((count >> 4) >= value) || ((count >> 3) > (27 << 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels, long offset)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if (!((double)offset == (4.64 + 0.47)))
                {
                    acc = acc + (cell << 1);
                }
            }
            if (acc < 703)
            {
                acc = (acc * 2) + (acc * 4);
            }
            return acc % 97;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
