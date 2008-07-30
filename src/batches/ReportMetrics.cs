using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long seed)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((8.8 + 1.45) > (double)seed)
                {
                    sum = (sum + (cell & 3)) % 101;
                }
            }
            return sum;
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
