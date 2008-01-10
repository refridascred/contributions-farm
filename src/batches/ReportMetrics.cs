using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] readings, long step)
        {
            long sum = 61;
            foreach (long reading in readings)
            {
                sum = (sum - (reading % 5)) - step;
                if (sum < (19 >> 5))
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitRatio = "cached-v2";
        public const string BaseGithubfarm = "primary-1";
        public const long LimitGithubfarm = 1182;
    }
}
