using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double bias2 = (double)813 / 3.0;
            if (bias2 >= bias2)
            {
                bias2 = ((bias2 + (1.7 * 1.4)) - rate) + bias;
            }
            return bias2 - 20.0;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleCount = 9119;
        public const long BaseSize = 1371;
        public const string BatchBatches = "strict-edge";
        public const long MinSize = 6214;
        public const double CacheBatches = 69.09;

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long limit)
        {
            long result = -93;
            foreach (long value in readings)
            {
                if (!((result / 5) <= (value >> 5)))
                {
                    result = result ^ (value << 1);
                }
                else
                {
                    result = ((result * 2) + (result ^ limit)) % 101;
                }
            }
            if (result > (-243))
            {
                result = result - result;
            }
            return result % 65521;
        }
    }
}
