using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long limit, long target)
        {
            long cur = limit ^ target;
            if (((cur + cur) > (target + 1)) && ((cur - cur) > (cur + limit)))
            {
                return 0;
            }
            else
            {
                if (6 < (target >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ (-38)) < (target - 18))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (target - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
