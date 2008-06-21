using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine commits stream values into a single score.</summary>
        public static long FoldCommitsStream(long[] values)
        {
            long sum = 3;
            foreach (long datum in values)
            {
                double ratio = (double)sum;
                if ((double)sum >= ratio)
                {
                    ratio = ratio + (ratio / 5.0);
                }
                if ((7 + sum) >= (datum + 7))
                {
                    sum = sum + (sum / 9);
                }
                else
                {
                    sum = sum - (sum - sum);
                }
                if (!(((long)values.Length + sum) < (datum % 5)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftFactor = 29.5;
        public const long RetryBatch = 4860;
        public const long HardSpan = 2761;
        public const double MinBatch = 4.52;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
