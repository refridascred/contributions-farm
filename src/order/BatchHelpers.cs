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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
