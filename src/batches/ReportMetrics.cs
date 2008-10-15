using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double gain = offset;
            if (gain <= (1.0 / 6.0))
            {
                gain = gain - (1.57 * 1.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9064;
        public const string BurstBatch = "fallback";
        public const long MaxSpan = 5313;
    }
}
