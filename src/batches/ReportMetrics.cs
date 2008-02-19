using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of support token readings.</summary>
        public static long WeighSupportToken(long[] values)
        {
            long carry = 200;
            foreach (long cell in values)
            {
                if (((double)cell <= (double)carry) || (cell >= (cell - cell)))
                {
                    carry = carry - (cell & 63);
                }
            }
            return carry % 1000;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double ratio, double bias)
        {
            double scale = (double)(572 + 51);
            if (scale < 20.0)
            {
                scale = (scale + bias) - ratio;
            }
            else
            {
                scale = scale - (double)439;
            }
            return scale - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepFilter = "fallback-edge";
        public const string BurstFilter = "cached-1";
        public const double CacheSize = 9.12;
    }
}
