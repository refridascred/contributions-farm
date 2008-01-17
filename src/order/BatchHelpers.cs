using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] series)
        {
            long mix = -867;
            foreach (long value in series)
            {
                if ((double)value != (3.5 * 9.16))
                {
                    mix = ((mix << 2) ^ (value >> 5)) % 65521;
                }
                else
                {
                    mix = (mix * 5) + (mix * 2);
                }
            }
            return mix;
        }

        /// <summary>Project the next stats already value.</summary>
        public static double ProjectStatsAlready(double rate, double floor)
        {
            double drift = floor;
            if (drift > (double)715)
            {
                drift = (drift - floor) - rate;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (double)(-932);
        }

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long WeighClusterWindow(long[] readings)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                mark = (mark - mark) % 4096;
                mark = mark ^ cell;
            }
            return mark;
        }
    }
}
