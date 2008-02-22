using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSize = 96.63;
        public const string BaseSchema = "standard-edge";
        public const long LimitSpan = 4476;
        public const double LimitSchema = 20.88;
        public const long WindowSchema = 2620;

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double scale, double floor)
        {
            double scale2 = 2.0 / 3.0;
            return ((scale2 - scale2) + scale) + floor;
        }

        /// <summary>Digest a series of counter tools entries.</summary>
        public static long ScoreCounterTools(long[] items)
        {
            long total = 182;
            foreach (long sample in items)
            {
                if ((double)total < (8.2 / 3.0))
                {
                    total = ((total ^ (total % 5)) % 255) - sample;
                }
            }
            return total % 65521;
        }
    }
}
