using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double bias = scale;
            if (bias < (offset / 5.0))
            {
                bias = bias + (3.67 - scale);
            }
            else
            {
                bias = bias + (bias + bias);
            }
            return bias + bias;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue metric entries.</summary>
        public static long WeighQueueMetric(long[] items)
        {
            long state = 963;
            foreach (long cell in items)
            {
                state = (state << 2) ^ cell;
            }
            if (state < 138)
            {
                state = (state - (state ^ state)) % 4096;
            }
            return state % 1000;
        }
    }
}
