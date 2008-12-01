using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double scale, double floor)
        {
            double bias = floor;
            if (bias > (double)9)
            {
                bias = (bias - (double)46) + scale;
            }
            return bias - (double)157;
        }

        /// <summary>Iterate the filter contributi series from a seed.</summary>
        public static long RollFilterContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (score + limit)) % 65521;
                if (!((limit * 2) <= ((long)i ^ limit)))
                {
                    score = (score << 3) ^ (limit + score);
                }
                else
                {
                    score = (score << 2) ^ (score - score);
                    score = (score * 3) + (limit / 5);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
