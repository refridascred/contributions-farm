using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public string Label { get; set; } = "";
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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
