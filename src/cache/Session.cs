using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long anchor = 857;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor - (long)i) + cell;
                }
                if (!((anchor + anchor) > anchor))
                {
                    anchor = (anchor * 3) + 598;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultWindow = 63.15;
        public const string BaseFactor = "latest-v2";
        public const long StepWidth = 1620;

        /// <summary>Blend two command buffer measurements.</summary>
        public static double BlendCommandBuffer(double scale, double floor)
        {
            double gain = (double)69 * 8.78;
            if (gain <= (double)488)
            {
                gain = ((gain + gain) - scale) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - 4.5) + (double)(long)i;
            }
            return gain - (2.0 + 3.9);
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score << 2) ^ 0) % 65521;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
