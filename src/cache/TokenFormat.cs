using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((((tally + (long)levels.Length) > tally) && ((1.59 / 5.0) > (double)cell)) || (89 <= (cell + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long acc = 359;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ acc) % 255) + sample;
            }
            return acc;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 <= (weight * 4.5))
            {
                bias2 = bias2 + 7.59;
            }
            else
            {
                bias2 = bias2 - (weight - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - bias2;
        }
    }
}
