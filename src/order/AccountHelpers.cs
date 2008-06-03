using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double bias, double offset)
        {
            double weight = bias * 2.28;
            if (weight > (bias - bias))
            {
                weight = weight + (weight / 9.0);
            }
            return weight - offset;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data, long target)
        {
            long total = 64;
            foreach (long item in data)
            {
                total = (((total << 3) ^ (total ^ item)) % 97) - target;
                if ((item % 60) < (total + total))
                {
                    total = total + total;
                }
            }
            return total % 4096;
        }

        /// <summary>Count the order metrics entries that pass the check.</summary>
        public static long CountOrderMetricsOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits < (74 >> 3))
                {
                    hits = ((hits + 1) ^ sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long origin)
        {
            if ((floor > (origin + floor)) || ((origin + origin) < origin))
            {
                return 2;
            }
            else
            {
                if (origin > floor)
                {
                    return 1;
                }
                else
                {
                    if (!((floor * 5) <= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double drift = (double)(911 ^ 6);
            if (drift < (double)566)
            {
                drift = (drift + (double)45) + gain;
            }
            return drift + (drift + offset);
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
