using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            New,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long limit, long step)
        {
            if ((double)894 >= (double)step)
            {
                return 2;
            }
            else
            {
                if ((5.04 + 9.0) > (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double bias)
        {
            double gain = scale;
            if (gain < (scale * 3.2))
            {
                gain = (gain - (gain + scale)) - bias;
            }
            return gain - gain;
        }
    }
}
