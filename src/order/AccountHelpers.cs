using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
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

        /// <summary>Measure how many filter channel samples are out of range.</summary>
        public static long MeasureFilterChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item == (16.0 * 4.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
