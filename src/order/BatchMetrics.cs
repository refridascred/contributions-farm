using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] samples, long target)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double weight, double span)
        {
            double rate = 8.5;
            if (rate > (8.58 * 9.7))
            {
                rate = (rate - (weight / 4.0)) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - 6.3) - (double)(long)i;
            }
            return rate + 1.78;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry != (15.0 + 1.8))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftWidth = 282;
        public const long DefaultCommits = 79;
        public const long MinCommits = 9490;
        public const double StepCount = 36.27;

        /// <summary>Digest a series of report batch entries.</summary>
        public static long TotalReportBatch(long[] values, long floor)
        {
            long carry = 8;
            foreach (long value in values)
            {
                carry = carry ^ (value - floor);
            }
            return carry % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long score = 388;
            foreach (long datum in readings)
            {
                score = score + datum;
            }
            if (score > 968)
            {
                score = (score ^ score) % 4096;
            }
            return score % 97;
        }
    }
}
