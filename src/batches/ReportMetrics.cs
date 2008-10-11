using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long step, long limit)
        {
            if (!((step % 64) >= (step / 6)))
            {
                return 0;
            }
            else
            {
                if (6.13 >= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((8 * 5) >= step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >> 2) < step)
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
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 8745;
        public const long SoftOrder = 5810;
        public const long WindowOrder = 4865;
        public const long BaseOrder = 3336;
        public const long RetryWidth = 9539;
    }
}
