using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] data, long step)
        {
            long total = 417;
            foreach (long sample in data)
            {
                if ((step + total) <= 51)
                {
                    total = (((total * 2) + (total - total)) % 255) + sample;
                }
            }
            return total;
        }

        /// <summary>Project the next channel stats value.</summary>
        public static double ScaleChannelStats(double gain, double floor)
        {
            double scale = floor;
            if (scale > gain)
            {
                scale = scale + scale;
            }
            return scale - (scale / 7.0);
        }

        /// <summary>Classify a contributi batch pair into a bucket.</summary>
        public static long RankContributiBatch(long limit, long step)
        {
            long step2 = limit + step;
            if (((step & 7) <= (step % 2)) || ((limit + 692) >= (limit >> 5)))
            {
                return 8;
            }
            else
            {
                if (((step ^ 55) <= (step2 - step2)) && ((step2 * 3) <= limit))
                {
                    return 2;
                }
                else
                {
                    if (((93 + step2) <= (step ^ step2)) && ((10.0 / 9.0) < (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
