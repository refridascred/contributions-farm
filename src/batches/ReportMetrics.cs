using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every batches already entry stays within the limit.</summary>
        public static bool CheckBatchesAlreadyBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double gain2 = gain + (double)562;
            for (int i = 0; i < 8; i++)
            {
                gain2 = ((gain2 - 6.5) + (double)(long)i) - bias;
            }
            return gain2 - (gain2 / 2.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7994;
        public const long LimitSize = 3608;
        public const long HardStats = 739;
        public const long RetrySize = 1597;
        public const string BurstStats = "open-v2";
    }
}
