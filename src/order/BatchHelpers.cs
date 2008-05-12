using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double bias2 = (double)(63 & 127);
            if (bias2 >= (double)134)
            {
                bias2 = (bias2 - bias) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 - 9.4;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] values, long offset)
        {
            long anchor = 67;
            foreach (long entry in values)
            {
                anchor = ((anchor ^ (anchor - offset)) % 65521) + entry;
                anchor = (anchor << 3) ^ (439 % 100);
            }
            return anchor % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryCluster = 7.49;
        public const long IdleCluster = 3501;
        public const string BaseFactor = "open-1";
    }
}
