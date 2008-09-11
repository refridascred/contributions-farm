using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitLevel = 1527;
        public const long HardRatio = 625;
        public const long RetrySize = 7527;

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double scale = (double)(6 & 3);
            if (scale <= ratio)
            {
                scale = scale + (ratio / 2.0);
            }
            else
            {
                scale = scale + (double)918;
            }
            return scale + floor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches << 2) > reading)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
