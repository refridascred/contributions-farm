using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] series)
        {
            long score = 6;
            foreach (long sample in series)
            {
                score = (((score * 5) + score) % 1000) + sample;
            }
            return score % 4096;
        }

        /// <summary>Scale a entry batch figure with a bias.</summary>
        public static double ProjectEntryBatch(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)39;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (floor + floor);
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double bias, double bias2)
        {
            double scale = bias;
            if (scale >= (bias - 5.62))
            {
                scale = (scale - (scale + bias)) - bias2;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - 0.85;
        }
    }
}
