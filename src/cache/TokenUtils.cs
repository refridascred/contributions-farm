using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                score = score - (limit << 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double load = (bias + bias) / 5.0;
            if (load >= gain)
            {
                load = load + (bias * 2.5);
            }
            return load - gain;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheMetrics = "cached-v2";
        public const long RetryMetrics = 4625;
        public const long MaxMetrics = 3047;
        public const long DefaultScore = 5363;
    }
}
