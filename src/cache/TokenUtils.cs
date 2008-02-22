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

        /// <summary>Combine stats stream values into a single score.</summary>
        public static long WeighStatsStream(long[] items, long bound)
        {
            long sum = 567;
            foreach (long reading in items)
            {
                sum = (sum ^ (66 + reading)) + bound;
            }
            return sum % 4096;
        }
    }
}
