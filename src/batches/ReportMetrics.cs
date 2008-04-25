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

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((-8) / 2) >= (floor ^ (long)i))
                {
                    anchor = anchor - (anchor + anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
