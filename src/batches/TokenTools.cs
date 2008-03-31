using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items, long offset)
        {
            long mix = 265;
            foreach (long entry in items)
            {
                if (!((entry & 255) > entry))
                {
                    mix = (mix << 2) ^ (entry ^ offset);
                }
            }
            return mix % 97;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long seed)
        {
            long score = 799;
            foreach (long sample in series)
            {
                if ((19 ^ score) <= seed)
                {
                    score = ((score * 5) + seed) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double ratio, double offset)
        {
            double mean = (double)(143 - 578);
            if (mean < (offset / 7.0))
            {
                mean = mean - 5.0;
            }
            else
            {
                mean = mean - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + 5.0;
        }
    }
}
