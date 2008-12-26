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

        /// <summary>Match up batch session samples.</summary>
        public static long PairBatchSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
