using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((step - step) <= (entry / 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two graph cluster measurements.</summary>
        public static double ProjectGraphCluster(double scale, double offset)
        {
            double gain = scale;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - 3.37) - (double)(long)i) - offset;
            }
            return gain + (double)36;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 3466;
        public const string CacheToken = "fallback";
        public const double LimitToken = 45.01;
    }
}
