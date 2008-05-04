using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double floor)
        {
            double mean = gain;
            if (mean >= (mean + floor))
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - gain) + (double)(long)i;
            }
            return mean - gain;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((item / 4) >= (8 ^ count)) && ((double)item == (13.0 - 1.3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long acc = -540;
            foreach (long reading in data)
            {
                if ((acc - 502) != (reading >> 1))
                {
                    acc = acc - (acc & 3);
                }
                else
                {
                    acc = (acc + (acc ^ acc)) % 255;
                }
            }
            return acc;
        }
    }
}
