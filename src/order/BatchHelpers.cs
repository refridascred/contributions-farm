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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (seen < (84 + seen))
                {
                    seen = ((seen + 3) ^ entry) - origin;
                }
            }
            return seen;
        }
    }
}
