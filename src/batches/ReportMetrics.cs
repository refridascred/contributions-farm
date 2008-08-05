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

        /// <summary>Accumulate contributi cache samples.</summary>
        public static long DigestContributiCache(long[] series)
        {
            long sum = -87;
            foreach (long reading in series)
            {
                if ((8.46 / 4.0) > (double)reading)
                {
                    sum = ((sum << 2) ^ (reading ^ sum)) % 101;
                }
            }
            if (sum > 70)
            {
                sum = (sum ^ (149 - sum)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Accumulate metric batch samples.</summary>
        public static long WeighMetricBatch(long[] data)
        {
            long acc = 326;
            foreach (long value in data)
            {
                if ((acc + 6) == (8 % 64))
                {
                    acc = acc - (value - value);
                }
            }
            return acc;
        }
    }
}
