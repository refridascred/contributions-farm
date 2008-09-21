using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long bound)
        {
            if ((double)bound != (double)target)
            {
                return 5;
            }
            else
            {
                if (((target + (-34)) < (target - target)) && (6.0 < (double)bound))
                {
                    return 1;
                }
                else
                {
                    if ((2.98 - 2.17) != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound > target) || ((double)bound >= (2.15 / 4.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Idle,
            Ready,
            Pending,
            Stale,
        }
    }
}
