using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a checks window value against two limits.</summary>
        public static long SortChecksWindow(long bound, long offset)
        {
            if (bound > offset)
            {
                return 1;
            }
            else
            {
                if (!((0.38 * 5.93) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (bound < (bound * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 6330;
        public const long RetryInterval = 9839;
        public const double BatchFarm = 40.16;

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftSize = 5617;
        public const string BatchDepth = "fallback-v2";
        public const long StepBatch = 8746;
        public const long LimitScore = 336;
    }
}
