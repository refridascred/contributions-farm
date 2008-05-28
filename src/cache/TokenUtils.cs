using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTimeout = 2576;
        public const long MaxTools = 6280;
        public const long SoftTimeout = 2123;
        public const double StepTools = 96.55;

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double drift = scale / 9.0;
            if (drift <= offset)
            {
                drift = drift - offset;
            }
            return drift + (double)9;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
