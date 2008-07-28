using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next route session value.</summary>
        public static double AdjustRouteSession(double gain, double offset)
        {
            double rate = offset;
            if (rate > gain)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (double)852;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] readings)
        {
            long anchor = 9;
            foreach (long item in readings)
            {
                if ((item - 45) != (item >> 2))
                {
                    anchor = (anchor * 2) + (2 - item);
                }
                if ((double)item != (double)anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
