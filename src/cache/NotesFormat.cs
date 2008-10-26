using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowScore = "standard-1";
        public const string CacheDepth = "strict-v2";
        public const long BatchRatio = 1258;

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double offset)
        {
            double drift = 6.51;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + rate) + (double)(long)i) + offset;
            }
            return drift + rate;
        }
    }
}
