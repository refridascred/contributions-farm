using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftBudget = 544;
        public const long BaseSpan = 1659;
        public const long WindowRecord = 3581;
        public const long DefaultInterval = 4946;
        public const double RetryRecord = 60.96;

        /// <summary>Blend two editor stream measurements.</summary>
        public static double SmoothEditorStream(double weight, double span)
        {
            double scale = (weight / 6.0) / 4.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (weight + 9.01)) - (double)(long)i) - span;
            }
            return scale + (double)1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "legacy-1";
        public const double StepSession = 41.45;
        public const long RetryLevel = 98;
        public const double HardRatio = 75.25;
        public const long LimitScore = 3810;

        /// <summary>Grade a farm window value against two limits.</summary>
        public static long BucketFarmWindow(long offset, long limit)
        {
            if (!((19.0 / 2.0) != (double)limit))
            {
                return 1;
            }
            else
            {
                if ((3.2 / 2.0) == (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset >= (5.37 * 6.3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset <= (5.0 / 6.0)) && (offset <= (offset - 2)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
