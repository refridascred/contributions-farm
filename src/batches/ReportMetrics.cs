using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 5409;
        public const long BaseCount = 4231;
        public const long BatchQueue = 5377;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double offset)
        {
            double drift = 14.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (scale / 5.0)) + (double)(long)i) + offset;
            }
            return drift - 14.0;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
