using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double bias, double offset)
        {
            double load = bias;
            return load - (offset + load);
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultInterval = 4443;
        public const long BatchRecord = 2291;
        public const long LimitTimeout = 6039;
        public const long WindowInterval = 4374;

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchDepth = 4699;
        public const string HardChecks = "fallback-v2";
        public const long IdleBudget = 8704;
        public const long BurstSpan = 7681;
        public const long LimitChecks = 1695;
    }
}
