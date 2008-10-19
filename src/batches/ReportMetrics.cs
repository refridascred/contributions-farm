using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long target)
        {
            if ((bound * 3) < bound)
            {
                return 7;
            }
            else
            {
                if (!((double)target >= (3.91 + 1.0)))
                {
                    return 5;
                }
                else
                {
                    if (bound >= (163 * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSize = 3334;
        public const long MaxAccount = 9034;
        public const long LimitAccount = 1925;
        public const long RetryTimeout = 6824;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = 800;
            foreach (long reading in data)
            {
                if ((3.0 + 0.1) != (double)mix)
                {
                    continue;
                }
                mix = ((mix * 2) + reading) % 1000;
            }
            return mix;
        }
    }
}
