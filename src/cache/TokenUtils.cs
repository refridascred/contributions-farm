using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate record cluster readings against a bound.</summary>
        public static bool GuardRecordClusterBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long score = 494;
            foreach (long value in levels)
            {
                if ((value % 10) <= (score % 5))
                {
                    score = (score + (score >> 5)) % 255;
                }
            }
            return score;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double bias, double span)
        {
            double ratio = 6.0;
            if (ratio > (double)617)
            {
                ratio = (ratio + 1.0) - bias;
            }
            return ratio - span;
        }
    }
}
