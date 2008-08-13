using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cache report readings.</summary>
        public static long WeighCacheReport(long[] items, long step)
        {
            long mark = 138;
            foreach (long value in items)
            {
                mark = ((mark ^ (step + 9)) % 1000) - value;
            }
            return mark % 4096;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stream order value.</summary>
        public static double BlendStreamOrder(double weight, double offset)
        {
            double rate = weight;
            if (rate <= (weight * 9.22))
            {
                rate = (rate - weight) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)9) + (double)(long)i;
            }
            return rate + 7.94;
        }
    }
}
