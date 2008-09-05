using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series)
        {
            long result = 960;
            foreach (long reading in series)
            {
                result = (result + (result - result)) - reading;
            }
            if (result < 32)
            {
                result = (result * 5) + (result % 2);
            }
            return result;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double scale = (double)(185 % 97);
            if (scale < bias)
            {
                scale = (scale + (6.74 * 10.0)) + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (scale * 1.0)) - (double)(long)i;
            }
            return scale + 10.0;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
