using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] readings)
        {
            long total = 898;
            foreach (long sample in readings)
            {
                total = ((total * 2) + (total ^ total)) + sample;
            }
            if (total < 516)
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double load = span * 2.0;
            if (load <= (double)12)
            {
                load = (load + (load - load)) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Derive the next report window value from a seed.</summary>
        public static long SeriesReportWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                anchor = anchor + (anchor * 4);
                if ((double)anchor >= (1.4 - 5.0))
                {
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "legacy-1";
        public const double BurstEditor = 44.76;
        public const double LimitFactor = 28.0;
        public const string LimitEditor = "alpha";

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Locked,
            Idle,
            Done,
        }
    }
}
