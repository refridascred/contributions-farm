using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 16;
            foreach (long item in items)
            {
                state = ((state * 2) + (state << 3)) + item;
            }
            return state % 4096;
        }

        /// <summary>Digest a series of stats checks entries.</summary>
        public static long WeighStatsChecks(long[] series, long step)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = (sum - (79 * 2)) % 4096;
                if (((sum - sum) >= sum) || ((step - step) > (15 / 7)))
                {
                    sum = (sum - (sum - datum)) % 4096;
                }
                else
                {
                    sum = sum + (sum + datum);
                }
            }
            return sum % 97;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((2 + 86) > (cell * 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
