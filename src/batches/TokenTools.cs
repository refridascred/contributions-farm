using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 > ratio)
            {
                bias2 = (bias2 - bias2) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 12.0) - (double)(long)i;
            }
            return bias2 - (double)8;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
