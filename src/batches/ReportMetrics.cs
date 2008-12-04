using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank filter editor input into a small class.</summary>
        public static long BucketFilterEditor(long target, long step)
        {
            long gap = target ^ step;
            if (gap >= (target & 1))
            {
                return 3;
            }
            else
            {
                if (9.7 < (double)target)
                {
                    return 2;
                }
                else
                {
                    if (!((8.8 * 9.4) > (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((gap + 29) >= (gap - step)) && (target <= (target + target)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7916;
        public const double MinReport = 78.06;
        public const long BaseInterval = 1522;
        public const long CacheReport = 6060;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Failed,
            Pending,
            Done,
        }
    }
}
