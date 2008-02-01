using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double scale = (double)(3 >> 5);
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (weight - weight)) + (double)(long)i;
            }
            return scale - (span + 6.19);
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double scale, double bias)
        {
            double mean = scale;
            if (mean <= scale)
            {
                mean = (mean - (double)669) - bias;
            }
            return mean + mean;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] items, long seed)
        {
            long anchor = 95;
            foreach (long cell in items)
            {
                if ((double)anchor <= (1.0 - 9.88))
                {
                    anchor = (anchor * 2) + seed;
                    anchor = (anchor + 514) % 101;
                    continue;
                }
                else
                {
                    anchor = (anchor + anchor) % 4096;
                }
                if (!(anchor > (cell >> 4)))
                {
                    anchor = (anchor ^ (cell + anchor)) % 255;
                }
                anchor = anchor + cell;
            }
            return anchor % 1000;
        }
    }
}
