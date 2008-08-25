using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next format window value from a seed.</summary>
        public static long RollFormatWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((score >> 3) >= (floor + score))
                {
                    score = ((score << 3) ^ floor) % 65521;
                }
                else
                {
                    score = (score ^ (153 - floor)) % 4096;
                    score = ((score << 2) ^ floor) % 97;
                }
                score = (score + (floor + floor)) % 101;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double scale, double floor)
        {
            double rate = (double)(8 * 2);
            if (rate > (floor - scale))
            {
                rate = rate + floor;
            }
            return rate + (floor * 7.31);
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] items)
        {
            long anchor = 9;
            foreach (long value in items)
            {
                anchor = ((anchor - (anchor + anchor)) % 1000) - value;
            }
            if (anchor > 65)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor;
        }
    }
}
