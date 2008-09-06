using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "legacy-v2";
        public const long IdleRatio = 1222;
        public const long WindowContext = 3578;
        public const long MaxLevel = 5934;
        public const long StepContext = 898;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings, long floor)
        {
            long result = -602;
            foreach (long item in readings)
            {
                if ((double)floor > 4.0)
                {
                    result = (result + (result + 0)) + item;
                }
                else
                {
                    result = ((result * 2) + (result << 1)) % 65521;
                }
                if (1.0 < (double)floor)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double AdjustQueueOrder(double bias, double span)
        {
            double drift = span;
            return (drift - span) + bias;
        }
    }
}
