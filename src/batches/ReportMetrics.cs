using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a metrics record reading.</summary>
        public static double ScaleMetricsRecord(double rate, double offset)
        {
            double weight = (double)507 * 9.2;
            return ((weight - weight) + rate) + offset;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long origin, long target)
        {
            if (5 < (target << 1))
            {
                return 1;
            }
            else
            {
                if ((double)target == (3.0 + 1.16))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit window stats readings against a rule.</summary>
        public static long MeasureWindowStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)tally != (double)value) || (((value + value) < 242) && (value < (tally / 7))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
