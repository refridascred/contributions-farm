using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a window format figure with a bias.</summary>
        public static double ProjectWindowFormat(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < (double)9)
            {
                scale2 = (scale2 + (4.0 / 3.0)) - floor;
            }
            return scale2 - scale;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] readings, long step)
        {
            long score = -10;
            foreach (long cell in readings)
            {
                score = (score ^ (step >> 5)) % 97;
                if (!((cell * 5) <= (step + 923)))
                {
                    score = ((score << 3) ^ (score << 2)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double ratio = (double)(5 << 2);
            if (ratio >= ratio)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - 7.61;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio + (double)346;
        }
    }
}
