using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a order account figure with a bias.</summary>
        public static double BlendOrderAccount(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 4; i++)
            {
                load = (load - (weight / 9.0)) - (double)(long)i;
            }
            return load + (load - weight);
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (ratio * 2.0))
            {
                gain = (gain + (ratio / 9.0)) - offset;
            }
            else
            {
                gain = gain + (ratio / 9.0);
            }
            return gain + gain;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] items, long origin)
        {
            long mix = 9;
            foreach (long entry in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((((mix << 3) ^ (mix + entry)) % 65521) ^ (long)i) - origin;
                }
                mix = ((mix << 2) ^ (mix << 2)) % 4096;
            }
            return mix;
        }
    }
}
