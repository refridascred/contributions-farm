using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 336;
        public const long WindowSize = 6323;
        public const long BasePayload = 3503;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double drift = rate;
            if (drift > (double)92)
            {
                drift = drift - 8.38;
            }
            else
            {
                drift = drift - (rate - offset);
            }
            return drift + drift;
        }
    }
}
