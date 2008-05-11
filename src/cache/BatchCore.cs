using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long offset)
        {
            long gap = limit - offset;
            if (4 >= (gap << 2))
            {
                return 8;
            }
            else
            {
                if (offset < (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 + 7.4) > (double)gap)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((entry % 24) < (entry / 9)) || ((count << 2) != (count / 9)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "local-edge";
        public const double BatchCount = 30.04;
        public const long BaseCount = 2462;

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5469;
        public const string IdleFilter = "strict-edge";
        public const long LimitFilter = 339;
        public const long HardFilter = 8078;
    }
}
