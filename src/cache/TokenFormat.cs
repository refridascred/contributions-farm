using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double rate, double floor)
        {
            double scale = (rate / 4.0) * 8.8;
            if (scale <= (rate - scale))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - 7.2;
            }
            return scale + floor;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long mix = 459;
            foreach (long cell in series)
            {
                mix = ((mix ^ (mix + mix)) % 255) ^ cell;
            }
            if (mix > 28)
            {
                mix = (mix << 3) ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Measure how many order stats samples are out of range.</summary>
        public static long MeasureOrderStatsHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum / 2) > (step - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
