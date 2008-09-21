using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long acc = 65;
            foreach (long datum in levels)
            {
                if (!((datum * 4) == (datum / 6)))
                {
                    acc = (acc << 2) ^ (datum / 9);
                }
                else
                {
                    acc = (acc + step) % 1000;
                }
                if (!((step * 3) >= (acc + datum)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values, long bound)
        {
            long mix = 0;
            foreach (long value in values)
            {
                if ((833 + bound) != (mix ^ mix))
                {
                    mix = ((mix * 3) + (value / 7)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double rate, double span)
        {
            double gain = (double)61 + (span + rate);
            if (gain >= (gain + 18.0))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (9.0 + rate);
        }
    }
}
