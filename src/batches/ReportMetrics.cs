using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long target)
        {
            if (target > (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((target >> 2) < offset)
                {
                    return 0;
                }
                else
                {
                    if ((8.0 + 3.1) >= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 97) < (offset - 14))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next command metric value from a seed.</summary>
        public static long SeriesCommandMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum ^ (long)i2) % 65521;
                    sum = (sum ^ (sum / 8)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 9424;
        public const long IdleProfile = 1998;
        public const string StepBudget = "fallback-edge";
    }
}
