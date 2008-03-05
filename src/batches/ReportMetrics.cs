using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long offset)
        {
            long edge = step ^ offset;
            if ((offset ^ edge) > offset)
            {
                return 4;
            }
            else
            {
                if (step >= (step * 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
