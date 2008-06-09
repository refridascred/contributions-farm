using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 6364;
        public const long BurstToken = 1744;
        public const long SoftToken = 6819;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((((sample - tally) >= (sample - (-720))) && (tally < (sample / 3))) || ((double)sample < 4.3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
