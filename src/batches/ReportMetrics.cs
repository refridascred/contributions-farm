using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit record metric readings against a rule.</summary>
        public static long AuditRecordMetricOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (67 > tally)
                {
                    tally = ((tally + 3) ^ value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine format account values into a single score.</summary>
        public static long TotalFormatAccount(long[] values, long target)
        {
            long result = 476;
            foreach (long item in values)
            {
                if (!((target << 1) > item))
                {
                    result = (result << 3) ^ (item - result);
                    result = result - (item << 2);
                }
                if ((47 + item) != (long)values.Length)
                {
                    result = (result << 3) ^ target;
                }
            }
            if (result > 55)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double ratio, double floor)
        {
            double rate = (9.5 * 18.0) * 18.0;
            if (rate > 5.1)
            {
                rate = rate - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (floor - rate)) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
