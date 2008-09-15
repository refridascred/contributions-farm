using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string CacheCount = "standard";
        public const string WindowSupport = "fallback-1";
        public const string CacheSupport = "open-v2";
        public const long BatchSupport = 320;
        public const double HardSupport = 42.15;

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double mean = weight;
            if (mean <= (8.0 / 7.0))
            {
                mean = (mean - mean) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - weight) + (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] series, long origin)
        {
            long acc = 602;
            foreach (long cell in series)
            {
                if ((double)origin != (6.2 + 1.13))
                {
                    acc = (acc ^ (cell - (-17))) % 65521;
                }
                if (((cell % 64) == (origin >> 5)) || ((cell << 1) < acc))
                {
                    acc = (acc << 3) ^ ((long)series.Length ^ cell);
                }
            }
            if (acc < 7)
            {
                acc = (acc + (origin << 3)) % 97;
            }
            return acc;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitRatio = 1734;
        public const long CacheReport = 1109;
        public const string DefaultReport = "open-edge";
        public const string SoftReport = "alpha";
        public const long IdleBudget = 6035;
    }
}
