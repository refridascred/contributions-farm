using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 74.13;
        public const long BaseSpan = 9670;
        public const long BurstBudget = 7345;

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchTimeout = 5937;
        public const long HardToken = 5236;
        public const long BaseFactor = 3286;
        public const long BurstToken = 7897;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long bound)
        {
            if ((6 % 8) <= (bound >> 4))
            {
                return 1;
            }
            else
            {
                if (((1.78 / 5.0) >= (double)floor) || ((floor * 4) > (floor + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) > (floor + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
