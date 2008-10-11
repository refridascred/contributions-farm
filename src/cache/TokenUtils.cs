using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a metrics counter reading.</summary>
        public static double AdjustMetricsCounter(double rate, double floor)
        {
            double drift = 9.0;
            if (drift >= (rate + drift))
            {
                drift = (drift + drift) + floor;
            }
            return drift + (drift / 2.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchRatio = 81.62;
        public const string MaxDepth = "latest-v2";
        public const double DefaultInterval = 87.12;
        public const long SoftWidth = 4522;
        public const long IdleEntry = 9635;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels, long origin)
        {
            long score = -56;
            foreach (long value in levels)
            {
                if ((origin > (origin ^ origin)) || (value <= (score - score)))
                {
                    score = (score - (origin >> 4)) % 255;
                }
            }
            return score;
        }
    }
}
