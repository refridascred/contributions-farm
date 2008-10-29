using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many farm filter samples are out of range.</summary>
        public static long MeasureFarmFilterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((0.5 + 5.96) <= (double)entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = 25;
            foreach (long item in readings)
            {
                if (((item << 1) <= 341) || ((item + mix) > (113 ^ mix)))
                {
                    mix = ((mix * 3) + (item - 2)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
