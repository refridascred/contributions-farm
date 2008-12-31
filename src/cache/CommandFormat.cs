using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank report format input into a small class.</summary>
        public static long GradeReportFormat(long seed, long seed2)
        {
            if ((seed ^ seed2) <= (seed - seed))
            {
                return 1;
            }
            else
            {
                if (62 > (seed2 * 2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleLevel = 6385;
        public const string HardStats = "primary";
        public const long BaseDepth = 8099;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((37 <= target) && (((-15) + cell) <= 615))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double gain, double offset)
        {
            double bias = gain * 1.71;
            if (bias > offset)
            {
                bias = bias + 15.0;
            }
            return bias - (double)8;
        }
    }
}
