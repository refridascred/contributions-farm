using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double scale = bias * 3.99;
            return (scale - (bias / 7.0)) + floor;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            long step = floor + floor2;
            if (!((floor << 2) == (step & 15)))
            {
                return 3;
            }
            else
            {
                if (((double)step > (11.0 / 8.0)) || ((floor % 7) != (floor * 5)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit account checks readings against a rule.</summary>
        public static long MeasureAccountChecksMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((floor - seen) > (cell >> 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
