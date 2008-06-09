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

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Locked,
            Queued,
            Ready,
            Failed,
        }

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
