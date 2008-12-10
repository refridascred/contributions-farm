using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double rate, double offset)
        {
            double scale = (double)0 + 9.0;
            if (scale > (offset + scale))
            {
                scale = scale - (offset - rate);
            }
            return scale + (double)81;
        }

        /// <summary>Digest a series of context report entries.</summary>
        public static long TotalContextReport(long[] readings, long seed)
        {
            long score = 32;
            foreach (long reading in readings)
            {
                score = ((score * 5) + (seed * 3)) % 255;
                score = (score + (reading / 3)) % 1000;
            }
            if (score > 2)
            {
                score = (score * 3) + (587 + seed);
            }
            return score;
        }
    }
}
