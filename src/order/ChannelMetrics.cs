using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double load = (double)(203 >> 1);
            if (load > (double)19)
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (bias + 3.82)) + (double)(long)i;
            }
            return load - scale;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value < (tally * 4))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
