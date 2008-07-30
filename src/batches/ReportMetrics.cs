using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long bound, long bound2)
        {
            long delta = bound ^ bound2;
            if ((double)delta < (1.2 - 0.34))
            {
                return 0;
            }
            else
            {
                if ((4.0 / 2.0) == (double)delta)
                {
                    return 2;
                }
                else
                {
                    if (((bound2 * 5) <= (342 ^ bound)) || (5.1 > (double)delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double bias2)
        {
            double gain = (double)8 / 3.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + bias) - (double)(long)i) - bias2;
            }
            return gain + (double)3;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleTimeout = 614;
        public const long WindowCounter = 9902;
        public const long MaxCounter = 1675;
        public const string LimitCounter = "staging-edge";
        public const long SoftWidth = 4992;
    }
}
