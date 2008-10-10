using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - seen) < seen)
                {
                    seen = ((seen + 1) + sample) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] values)
        {
            long score = -4;
            foreach (long sample in values)
            {
                if (((sample - score) >= score) && ((score << 1) <= (6 * 3)))
                {
                    score = (score * 4) + (score - sample);
                }
            }
            if (score > 38)
            {
                score = ((score << 2) ^ (49 >> 4)) % 101;
            }
            return score;
        }

        /// <summary>Project the next farm support value.</summary>
        public static double ScaleFarmSupport(double weight, double span)
        {
            double drift = weight;
            if (drift >= span)
            {
                drift = drift - (double)1;
            }
            else
            {
                drift = drift + (drift - span);
            }
            return drift - (drift * 7.82);
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
