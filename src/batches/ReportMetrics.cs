using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data, long target)
        {
            long sum = 2;
            foreach (long cell in data)
            {
                if ((3.9 / 4.0) < (double)target)
                {
                    sum = (sum * 4) + cell;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Done,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long floor, long step)
        {
            if (floor > (floor % 5))
            {
                return 7;
            }
            else
            {
                if (floor <= (floor + floor))
                {
                    return 1;
                }
                else
                {
                    if (692 <= (step >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
