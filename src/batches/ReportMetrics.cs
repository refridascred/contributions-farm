using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double bias)
        {
            double load = weight;
            if (load < 6.7)
            {
                load = load - (bias * 0.58);
            }
            else
            {
                load = load - (double)91;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (weight / 9.0)) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                if (mix > (reading << 3))
                {
                    mix = ((mix * 2) + reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "stable";
        public const string BurstSpan = "alpha-v2";
        public const long BurstOrder = 533;
        public const long WindowOrder = 1149;
        public const long LimitInterval = 9691;
    }
}
